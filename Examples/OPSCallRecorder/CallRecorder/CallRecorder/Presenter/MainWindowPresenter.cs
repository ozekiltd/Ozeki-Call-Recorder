using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CallRecorder.Model;
using CallRecorder.Util;
using CallRecorder.View;
using System.Diagnostics;
using OPSSDK;
using OPSSDKCommon.Model.Extension;
using OPSSDKCommon.Model.Session;
using OzCommon.Model;
using Ozeki.VoIP;

namespace CallRecorder.Presenter
{
	class MainWindowPresenter
	{
		readonly IMainWindow view;
		readonly IOPSClient client;

		public event EventHandler<VoIPEventArgs<List<ExtensionInfo>>> ExtensionsListAvailable;
		public event EventHandler<VoIPEventArgs<List<ExtensionInfo>>> OutsideLinesListAvailable;

		readonly List<ExtensionInfo> recordings = new List<ExtensionInfo>();
		readonly List<RecordingContext> recording_contexts = new List<RecordingContext>();
		readonly object sync = new object();
		readonly object recording_sync = new object();

		public MainWindowPresenter(IMainWindow my_view, IOPSClient my_client)
		{
			view = my_view;
			client = my_client;

			client.SessionCreated += ClientOnSessionCreated;
			client.SessionCompleted += ClientOnSessionCompleted;
		}

		public void StartApplication(string application)
		{
			try
			{
				if (String.IsNullOrEmpty(application)) return;
				Process.Start(application);
			}
			catch (Exception ex)
			{
				view.ShowError(ex);
			}
		}
		
		public void OpenFolder(string path)
		{
			try
			{
				Process.Start("explorer", path);
			}
			catch (Exception ex)
			{
				view.ShowError(ex);
			}
		}

		public void GetExtensionsAndOutsideLines()
		{
			client.GetExtensionInfosAsync(Completed);
		}

		public void Connect()
		{
			if (!client.IsLoggedIn) view.ShowConnectToServerWindow();
			else view.ShowError("Connection failed", "You are already connected");
		}

		public List<ListViewItem> GetFileList(ListViewItem item, out int total_saved_files_number, out TimeSpan total_recording_length, out long total_file_size)
		{
			var result = new List<ListViewItem>();
			total_recording_length = new TimeSpan();
			total_file_size = 0;

			try
			{
				var filenames = GetFilenames(item);
				total_saved_files_number = filenames.Length;

				foreach (var filename in filenames)
				{
					var file_info = new FileInfo(filename);

					total_file_size += file_info.Length;

					var file_length = GetFileDurationFromFilename(filename);
					total_recording_length = total_recording_length.Add(file_length);

					result.Add(CreateItem(filename, file_info, file_length));
				}
			}
			catch (Exception ex)
			{
				total_saved_files_number = result.Count;
				view.ShowError(ex);
			}

			return result;
		}

		static string[] GetFilenames(ListViewItem item)
		{
			var info = (ExtensionInfo)item.Tag;
			var folder = Path.Combine(SettingsHelper.RecordingPath, item.Text);
			RecordingContext.CreateFolderIfNecessery(folder);

		    var fileNames = Directory.GetFiles(folder, "*.mp3").ToList();
            fileNames.AddRange(Directory.GetFiles(folder, "*.wav"));

		    return fileNames.ToArray();
		    //var filenames = Directory.GetFiles(folder, String.Concat(info.PhoneNumber, "_*.", SettingsHelper.RecordingFileFormat));
		    //var callee_filenames = Directory.GetFiles(folder, String.Concat("*_", info.PhoneNumber, "_*.", SettingsHelper.RecordingFileFormat));

		    //var old_length = filenames.Length;
		    //Array.Resize(ref filenames, filenames.Length + callee_filenames.Length);
		    //for (var i = old_length; i < filenames.Length; i++)
		    //{
		    //    filenames[i] = callee_filenames[i - old_length];
		    //}
		    //return filenames;
		}

		static ListViewItem CreateItem(string filename, FileInfo file_info, TimeSpan file_length)
		{
			var file_item = new ListViewItem(filename, 2);
			file_item.SubItems.Add(file_length.ToString());
			file_item.SubItems.Add((file_info.Length / Constants.DIVIDER).ToString("N2"));
			file_item.SubItems.Add(String.Format("{0} {1}", file_info.CreationTime.ToShortDateString(), file_info.CreationTime.ToLongTimeString()));
			return file_item;
		}

		public void StartRecording(ExtensionInfo info)
		{
			lock (sync)
			{
				recordings.Add(info);
			}
		}

		public void StopRecording(ExtensionInfo info)
		{
			lock (sync)
			{
				recordings.Remove(info);
			}
		}

		public void Disconnect()
		{
			if (!client.IsLoggedIn)
			{
				view.ShowError("Disconnect failed", "You are not connected");
				return;
			}

			view.SetState(LoginState.LoggedOut);

			client.Logout();
		}

		public void DeleteFile(string filename)
		{
			try
			{
				if (filename != null) File.Delete(filename);
				else view.ShowError("File delete error", "No file has been selected");
			}
			catch (Exception ex)
			{
				view.ShowError(ex);
			}
		}

		public void StopRecordings()
		{
			lock (recording_sync)
			{
				foreach (var recording_context in recording_contexts)
				{
					try
					{
						recording_context.StopRecording();
					}
					catch (Exception ex)
					{
						view.ShowError(ex);
					}
				}
				recording_contexts.Clear();
			}
		}

		public void SaveSettings(List<string> extensions_to_record, List<string> outside_lines_to_record)
		{
			try
			{
				var setting_container = SimpleIOCContainer.Instance.Resolve<IGenericSettingsRepository<ProgramSettings>>();
				var settings = setting_container.GetSettings();
				settings.RecordableExtensions = extensions_to_record;
				settings.RecordableOutsideLines = outside_lines_to_record;
				SettingsHelper.SaveOptions(settings);
			}
			catch (Exception ex)
			{
				view.ShowError(ex);
			}
		}

		static TimeSpan GetFileDurationFromFilename(string filename)
		{
			var info = new FileInfo(filename);
			return info.LastWriteTimeUtc.Subtract(info.CreationTimeUtc);
		}

		void Completed(List<ExtensionInfo> extension_infos)
		{
			var extensions = new List<ExtensionInfo>();
			var outside_lines = new List<ExtensionInfo>();

			foreach (var extension_info in extension_infos)
			{
				switch (extension_info.ExtensionType)
				{
					case ExtensionType.Extension:
						extensions.Add(extension_info);
						break;
					case ExtensionType.OutsideLine:
						outside_lines.Add(extension_info);
						break;
				}
			}

			var handler = ExtensionsListAvailable;
			if (handler != null) handler(this, new VoIPEventArgs<List<ExtensionInfo>>(extensions));

			handler = OutsideLinesListAvailable;
			if (handler != null) handler(this, new VoIPEventArgs<List<ExtensionInfo>>(outside_lines));
		}

		ExtensionInfo ShouldRecordCallee(ISession session)
		{
			lock (sync)
			{
				foreach (var recording in recordings)
				{
					if (recording.PhoneNumber == session.Callee)
					{
						return recording;
					}
				}
			}
			return null;
		}

		ExtensionInfo ShouldRecordCaller(ISession session)
		{
			lock (sync)
			{
				foreach (var recording in recordings)
				{
					if (recording.PhoneNumber == session.Caller)
					{
						return recording;
					}
				}
			}
			return null;
		}
		
		void RecordSession(ISession session, bool callee)
		{
			var extension_info = callee ? ShouldRecordCallee(session) : ShouldRecordCaller(session);
			if (extension_info == null) return;

			lock (recording_sync)
			{
				try
				{
					var recording_context = new RecordingContext(session, SettingsHelper.RecordingFileFormat, extension_info.PhoneNumber);
					recording_contexts.Add(recording_context);
					recording_context.StartRecording();
				}
				catch (Exception ex)
				{
					view.ShowError(ex);
				}
			}
		}

		void ClientOnSessionCreated(object sender, VoIPEventArgs<ISession> vo_ip_event_args)
		{
			Debug.WriteLine(String.Concat("\t->\tClientOnSessionCreated ", vo_ip_event_args.Item.Caller, " ", vo_ip_event_args.Item.Callee));

			vo_ip_event_args.Item.SessionStateChanged += delegate(object o, VoIPEventArgs<SessionState> args)
				{
					Debug.WriteLine(String.Concat("\t->\tSessionStateChanged: ", args.Item));
					if (args.Item != SessionState.Ringing) return;

					RecordSession(vo_ip_event_args.Item, true);
					RecordSession(vo_ip_event_args.Item, false);
				};
		}

		IEnumerable<RecordingContext> GetRecordingContexts(ISession session)
		{
			Debug.WriteLine(String.Concat("\t->\tGetRecordingContext ", session.Caller, " ", session.Callee));

			var result = new List<RecordingContext>();
			lock (recording_sync)
			{
				foreach (var recording_context in recording_contexts)
				{
					if (recording_context.HasSession(session))
						result.Add(recording_context);
						//return recording_context;
				}
			}

			return result;
		}

		void ClientOnSessionCompleted(object sender, VoIPEventArgs<ISession> vo_ip_event_args)
		{
			Debug.WriteLine(String.Concat("\t->\tClientOnSessionCompleted ", vo_ip_event_args.Item.Caller, " ", vo_ip_event_args.Item.Callee));
			try
			{
				var my_recording_contexts = GetRecordingContexts(vo_ip_event_args.Item);

				lock (recording_sync)
				{
					foreach (var recording_context in my_recording_contexts)
					{
						recording_context.StopRecording();
						recording_contexts.Remove(recording_context);
					}
				}
			}
			catch (Exception ex)
			{
				view.ShowError(ex);
			}
		}
	}
}
