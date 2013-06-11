using System.Windows.Forms;

namespace CallRecorder.Util
{
	static class InfoBox
	{
		public static void Show(string title, string message)
		{
			MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
		}
	}
}
