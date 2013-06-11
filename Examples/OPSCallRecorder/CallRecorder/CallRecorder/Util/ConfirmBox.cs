using System.Windows.Forms;

namespace CallRecorder.Util
{
	static class ConfirmBox
	{
		public static DialogResult Show(string title, string message)
		{
			return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
		}
	}
}
