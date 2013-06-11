using System;
using System.IO;
using CallRecorder.Model;
using CallRecorder.Util;
using CallRecorder.View;
using OzCommon.Model;

namespace CallRecorder.Presenter
{
	class OptionsWindowPresenter
	{
		readonly IOptionsWindow view;

		public OptionsWindowPresenter(IOptionsWindow my_view)
		{
			view = my_view;
		}

		public void SaveSettings(string folder, RecordingFileFormat format)
		{
			try
			{
				var setting_container = SimpleIOCContainer.Instance.Resolve<IGenericSettingsRepository<ProgramSettings>>();
				var settings = setting_container.GetSettings();
				settings.RecordingPath = folder;
				settings.RecordingFileFormat = format;
				SettingsHelper.SaveOptions(settings);

                if (!Directory.Exists(settings.RecordingPath))
                    Directory.CreateDirectory(settings.RecordingPath);

			}
			catch (Exception ex)
			{
				view.ShowError(ex);
			}
		}
	}
}
