using System;
using System.Collections.Generic;
using System.IO;
using OPSSDK;
using OPSSDKCommon.Model.Call;
using Ozeki.Media;
using Ozeki.Media.MediaHandlers;

namespace CallRecorder.Model
{
	class RecordingContext : IEquatable<RecordingContext>
	{
		readonly ISession session;
		readonly RecordingFileFormat format;
		readonly MP3StreamRecorder mp3_recorder;
		readonly WaveStreamRecorder wav_recorder;
		readonly string recorder_filename;
		DateTime recording_started;
		TimeSpan recording_duration;

		readonly object sync = new object();
		static readonly Dictionary<RecordingContext, ConnectorContext> Connectors = new Dictionary<RecordingContext, ConnectorContext>();
		readonly string extension_subpath;

		public RecordingContext(ISession my_session, RecordingFileFormat my_format, string my_extension_subpath)
		{
			session = my_session;
			format = my_format;
			extension_subpath = my_extension_subpath;

			recorder_filename = Path.GetTempFileName();

			switch (format)
			{
				case RecordingFileFormat.MP3:
					mp3_recorder = new MP3StreamRecorder(recorder_filename);
					break;
				case RecordingFileFormat.WAV:
					wav_recorder = new WaveStreamRecorder(recorder_filename);
					break;
			}
		}

		public bool HasSession(ISession my_session)
		{
			return session.SessionID == my_session.SessionID;
		}

		public bool Equals(RecordingContext other)
		{
			return HasSession(other.session) && recorder_filename == other.recorder_filename;
		}

		void ConnectOrDisconnectAudioReceiver(AudioHandler receiver, bool connect)
		{
			if (receiver == null) return;

			if (connect)
			{
				var media_connector = new MediaConnector();
				var mixer = new AudioMixerMediaHandler();

				lock (sync)
				{
					Connectors.Add(this, new ConnectorContext(media_connector, mixer));
				}

				media_connector.Connect(mixer, receiver);

				session.ConnectAudioReceiver(CallParty.Callee, mixer);
				session.ConnectAudioReceiver(CallParty.Caller, mixer);
			}
			else
			{
				ConnectorContext connector_context;
				lock (sync)
				{
					connector_context = Connectors[this];
					Connectors.Remove(this);
				}

				session.DisconnectAudioReceiver(CallParty.Callee, connector_context.Mixer);
				session.DisconnectAudioReceiver(CallParty.Caller, connector_context.Mixer);

				connector_context.Connector.Disconnect(connector_context.Mixer, receiver);
				connector_context.Connector.Dispose();
				connector_context.Mixer.Dispose();
			}
		}

		public void StartRecording()
		{
			recording_started = DateTime.Now;
			switch (format)
			{
				case RecordingFileFormat.MP3:
					ConnectOrDisconnectAudioReceiver(mp3_recorder, true);
					mp3_recorder.StartStreaming();
					break;
				case RecordingFileFormat.WAV:
					ConnectOrDisconnectAudioReceiver(wav_recorder, true);
					wav_recorder.StartStreaming();
					break;
			} 
		}

		public static void CreateFolderIfNecessery(string path)
		{
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);
		}

		public void StopRecording()
		{
			recording_duration = DateTime.Now.Subtract(recording_started);
			var new_filename = String.Empty;
			switch (format)
			{
				case RecordingFileFormat.MP3:
					if (mp3_recorder.IsStreaming)
					{
						ConnectOrDisconnectAudioReceiver(mp3_recorder, false);
						mp3_recorder.StopStreaming();
						mp3_recorder.Dispose();
						new_filename = String.Format("{0}_{1}_{2}{3}{4}_{5}{6}{7}_{8}.mp3", session.Caller, session.Callee, recording_started.Year, recording_started.Month.ToString("D2"), recording_started.Day.ToString("D2"), recording_started.Hour.ToString("D2"), recording_started.Minute.ToString("D2"), recording_started.Second.ToString("D2"), recording_duration.ToString("hhmmss"));
					}
					break;
				case RecordingFileFormat.WAV:
					if (wav_recorder.IsStreaming)
					{
						ConnectOrDisconnectAudioReceiver(wav_recorder, false);
						wav_recorder.StopStreaming();
						wav_recorder.Dispose();
						new_filename = String.Format("{0}_{1}_{2}{3}{4}_{5}{6}{7}_{8}.wav", session.Caller, session.Callee, recording_started.Year, recording_started.Month.ToString("D2"), recording_started.Day.ToString("D2"), recording_started.Hour.ToString("D2"), recording_started.Minute.ToString("D2"), recording_started.Second.ToString("D2"), recording_duration.ToString("hhmmss"));
					}
					break;
				default:
					throw new NotImplementedException();
			}

			var path = Path.Combine(SettingsHelper.RecordingPath, extension_subpath);
			CreateFolderIfNecessery(path);
			File.Move(recorder_filename, Path.Combine(path, new_filename));
		}
	}
}
