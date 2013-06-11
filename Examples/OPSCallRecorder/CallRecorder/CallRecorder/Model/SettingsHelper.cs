using System;
using System.Collections.Generic;
using System.IO;
using CallRecorder.Util;
using OzCommon.Model;

namespace CallRecorder.Model
{
	static class SettingsHelper
	{
		readonly static ProgramSettings Settings;
		static readonly IGenericSettingsRepository<ProgramSettings> SettingContainer;

		static SettingsHelper()
		{
			SettingContainer = SimpleIOCContainer.Instance.Resolve<IGenericSettingsRepository<ProgramSettings>>();
			Settings = SettingContainer.GetSettings();
			if (Settings != null) return;

		    var appPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		    var callRecorderPath = Path.Combine(appPath, "Ozeki", "Call recorder");

			Settings = new ProgramSettings
				{
					RecordableExtensions = new List<string>(),
					RecordableOutsideLines = new List<string>(),
					RecordingFileFormat = RecordingFileFormat.MP3,
					RecordingPath = callRecorderPath
				};
			SettingContainer.SetSettings(Settings);
		}

		public static RecordingFileFormat RecordingFileFormat
		{
			get { return Settings.RecordingFileFormat; }
		}

		public static string RecordingPath
		{
			get { return Settings.RecordingPath; }
		}

		public static List<string> RecordableExtensions
		{
			get { return Settings.RecordableExtensions; }
		}

		public static List<string> RecordableOutsideLines
		{
			get { return Settings.RecordableOutsideLines; }
		}

		public static void SaveOptions(ProgramSettings settings)
		{
			SettingContainer.SetSettings(settings);
		}
	}
}
