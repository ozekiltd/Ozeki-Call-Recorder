using System;
using System.Windows.Forms;
using CallRecorder.Model;
using CallRecorder.Presenter;

namespace CallRecorder.View
{
	public partial class OptionsWindow : BaseWindow, IOptionsWindow
	{
		readonly OptionsWindowPresenter presenter;

		public OptionsWindow()
		{
			presenter = new OptionsWindowPresenter(this);
			InitializeComponent();

			ShowSettings();
		}

		void btn_Browse_Click(object sender, EventArgs e)
		{
			if (fbd_Browse.ShowDialog() == DialogResult.OK)
				tb_Browse.Text = fbd_Browse.SelectedPath;
		}

		void btn_OK_Click(object sender, EventArgs e)
		{
			presenter.SaveSettings(tb_Browse.Text, rb_Mp3.Checked ? RecordingFileFormat.MP3 : RecordingFileFormat.WAV);
		}

		public void ShowSettings()
		{
			switch (SettingsHelper.RecordingFileFormat)
			{
				case RecordingFileFormat.MP3:
					rb_Mp3.Checked = true;
					break;
				case RecordingFileFormat.WAV:
					rb_Wav.Checked = true;
					break;
			}

			tb_Browse.Text = SettingsHelper.RecordingPath;
		}
	}
}
