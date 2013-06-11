using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using CallRecorder.Model;
using CallRecorder.Presenter;
using CallRecorder.Util;
using OPSSDK;
using OPSSDKCommon.Model.Extension;
using Ozeki.VoIP;

namespace CallRecorder.View
{
	public partial class MainWindow : BaseWindow, IMainWindow
	{
		readonly MainWindowPresenter presenter;
		bool show_icon;
		readonly object sync = new object();

		public MainWindow()
		{
			InitializeComponent();

			presenter = new MainWindowPresenter(this, SimpleIOCContainer.Instance.Resolve<IOPSClient>());
			presenter.ExtensionsListAvailable += PresenterOnExtensionsListAvailable;
			presenter.OutsideLinesListAvailable += PresenterOnOutsideLinesListAvailable;
			presenter.Connect();

			lbl_FormatValue.Text = SettingsHelper.RecordingFileFormat.ToString();
			lbl_RecordingPathValue.Text = SettingsHelper.RecordingPath;
		}

		public void ShowDetailsOfListViewItem(ListViewItem item)
		{
			if (item == null)
			{
				lbl_StatusValue.Text = Constants.N_PER_A;
				lbl_TypeValue.Text = Constants.N_PER_A;
				lbl_TotalSavedFilesValue.Text = Constants.N_PER_A;
				lbl_TotalRecordingLengthValue.Text = Constants.N_PER_A;
				lbl_TotalFileSizeValue.Text = Constants.N_PER_A;
			}
			else
			{
				lbl_StatusValue.Text = item.Checked ? "Recording" : "Not recording";
				lbl_TypeValue.Text = ((ExtensionInfo)item.Tag).Type;

				int total_saved_files_number;
				TimeSpan total_recording_length;
				long total_file_size;

				var file_list = presenter.GetFileList(item, out total_saved_files_number, out total_recording_length, out total_file_size);

				InvokeGUI(() => lv_Files.Items.Clear());
				foreach (var list_view_item in file_list)
				{
					var my_item = list_view_item;
					InvokeGUI(() => lv_Files.Items.Add(my_item));
				}

				lbl_TotalSavedFilesValue.Text = total_saved_files_number.ToString();
				lbl_TotalRecordingLengthValue.Text = total_recording_length.ToString();
				lbl_TotalFileSizeValue.Text = (total_file_size / Constants.DIVIDER).ToString("N2");
			}
		}

		public string GetSelectedFilename()
		{
			return lv_Files.SelectedItems.Count == 1 ? lv_Files.SelectedItems[0].Text : null;
		}

		public void ShowConnectToServerWindow()
		{
			var connect = new ConnectToServerWindow();
			connect.ShowDialog(this);
			if (!connect.Connected)
			{
				SetState(LoginState.LoggedOut);
				return;
			}
			SetState(LoginState.LoggedIn);
			presenter.GetExtensionsAndOutsideLines();
		}

		public void SetState(LoginState state)
		{
			switch (state)
			{
				case LoginState.LoggedOut:
					InvokeGUI(() =>
						{
							tsmi_ConnectToServer.Enabled = true;
							tsmi_Disconnect.Enabled = false;
							lock (sync)
							{
								lv_Extension.Items.Clear();
								lv_OutsideLine.Items.Clear();
							}
							lv_Files.Items.Clear();
						});
					break;
				case LoginState.LoggingIn:
				case LoginState.LoggedIn:
					InvokeGUI(() =>
						{
							tsmi_ConnectToServer.Enabled = false;
							tsmi_Disconnect.Enabled = true;
						});
					break;
			}
		}

		static ListViewItem GetItemFromExtensionInfo(ExtensionInfo info)
		{
			var item = new ListViewItem(info.PhoneNumber)
				{
					Checked =
						info.ExtensionType == ExtensionType.Extension
							? SettingsHelper.RecordableExtensions.Contains(info.PhoneNumber)
							: SettingsHelper.RecordableOutsideLines.Contains(info.PhoneNumber),
					Tag = info
				};

			item.SubItems.Add(info.Type);
			return item;
		}

		void PresenterOnOutsideLinesListAvailable(object sender, VoIPEventArgs<List<ExtensionInfo>> vo_ip_event_args)
		{
			InvokeGUI(() => ClearListViewItems(lv_OutsideLine));

			foreach (var info in vo_ip_event_args.Item)
			{
				var item = GetItemFromExtensionInfo(info);
				InvokeGUI(() => AddItemToListView(lv_OutsideLine, item));
			}
		}

		void ClearListViewItems(ListView list)
		{
			lock (sync)
			{
				list.Items.Clear();
			}
		}
		
		void AddItemToListView(ListView list, ListViewItem item)
		{
			lock (sync)
			{
				list.Items.Add(item);
			}
		}

		void PresenterOnExtensionsListAvailable(object sender, VoIPEventArgs<List<ExtensionInfo>> vo_ip_event_args)
		{
			InvokeGUI(() => ClearListViewItems(lv_Extension));

			foreach (var info in vo_ip_event_args.Item)
			{
				var item = GetItemFromExtensionInfo(info);
				InvokeGUI(() => AddItemToListView(lv_Extension, item));
			}
		}

		void tsmi_About_Click(object sender, EventArgs e)
		{
			var about_box = new AboutBox();
			about_box.ShowDialog(this);
		}

		void tsmi_OpenOnlineDocumentation_Click(object sender, EventArgs e)
		{
			#if DEBUG
				presenter.StartApplication("http://inside.ozekiphone.com/call-recorder-634.html");
			#else
				presenter.StartApplication("http://www.ozekiphone.com/call-recorder-634.html");
			#endif
		}

		void tsmi_Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		void lv_Extension_SelectedIndexChanged(object sender, EventArgs e)
		{
			lock (sync)
			{
				ShowDetailsOfListViewItem(lv_Extension.SelectedItems.Count == 1 ? lv_Extension.SelectedItems[0] : null);
			}
		}

		void lv_OutsideLine_SelectedIndexChanged(object sender, EventArgs e)
		{
			lock (sync)
			{
				ShowDetailsOfListViewItem(lv_OutsideLine.SelectedItems.Count == 1 ? lv_OutsideLine.SelectedItems[0] : null);
			}
		}

		void InvokeGUI(Action action)
		{
			Invoke(action);
		}

		void lv_Extension_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			lock (sync)
			{
				if (e.Item == null) return;

				var info = e.Item.Tag as ExtensionInfo;
				if (info == null) throw new ArgumentNullException("info");

				if (e.Item.Checked) presenter.StartRecording(info);
				else presenter.StopRecording(info);

				if (e.Item.Checked)
				{
					if (info.ExtensionType == ExtensionType.Extension) SettingsHelper.RecordableExtensions.Add(info.PhoneNumber);
					else SettingsHelper.RecordableOutsideLines.Add(info.PhoneNumber);
				}
				else
				{
					if (info.ExtensionType == ExtensionType.Extension) SettingsHelper.RecordableExtensions.Remove(info.PhoneNumber);
					else SettingsHelper.RecordableOutsideLines.Remove(info.PhoneNumber);
				}
			}
		}

		void tsmi_ConnectToServer_Click(object sender, EventArgs e)
		{
			presenter.Connect();
		}

		void tsmi_Disconnect_Click(object sender, EventArgs e)
		{
			presenter.Disconnect();
		}

		void t_Timer_Tick(object sender, EventArgs e)
		{
			show_icon = !show_icon;
			var icon_index = show_icon ? 0 : -1;

			lock (sync)
			{
				foreach (ListViewItem item in lv_Extension.Items)
					item.ImageIndex = (item.Checked) ? icon_index : 1;

				lv_Extension.Invalidate();

				foreach (ListViewItem item in lv_OutsideLine.Items)
					item.ImageIndex = (item.Checked) ? icon_index : 1;

				lv_OutsideLine.Invalidate();
			}
		}

		void btn_OpenFilesLocation_Click(object sender, EventArgs e)
		{
			presenter.OpenFolder(SettingsHelper.RecordingPath);
		}

		void btn_DeleteFile_Click(object sender, EventArgs e)
		{
			presenter.DeleteFile(GetSelectedFilename());
			if (lv_Files.SelectedItems.Count == 1) lv_Files.Items.Remove(lv_Files.SelectedItems[0]);
		}

		void btn_Play_Click(object sender, EventArgs e)
		{
			presenter.StartApplication(GetSelectedFilename());
		}

		void tsmi_Preferences_Click(object sender, EventArgs e)
		{
			var ow = new OptionsWindow();
			if (ow.ShowDialog(this) != DialogResult.OK) return;

			lv_Files.Items.Clear();
			lbl_FormatValue.Text = SettingsHelper.RecordingFileFormat.ToString();
			lbl_RecordingPathValue.Text = SettingsHelper.RecordingPath;
		}

		void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			presenter.SaveSettings(SettingsHelper.RecordableExtensions, SettingsHelper.RecordableOutsideLines);
			presenter.StopRecordings();
		}
	}
}
