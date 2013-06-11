using System;
using System.Windows.Forms;
using CallRecorder.Util;

namespace CallRecorder.View
{
	public partial class BaseWindow : Form
	{
		public BaseWindow()
		{
			InitializeComponent();
		}

		public void ShowInfo(string title, string message)
		{
			InfoBox.Show(title, message);
		}

		public void ShowError(Exception ex)
		{
			ErrorBox.Show(ex);
		}

		public void ShowError(string title, string message)
		{
			ErrorBox.Show(title, message);
		}

		public WaitWindow ShowWaitWindow(string message = null)
		{
			var window = new WaitWindow(message);
			window.Show();
			return window;
		}

		public void CloseWaitWindow(WaitWindow window)
		{
			if (window != null)
				window.Close();
		}

		public new void Close()
		{
			if (!InvokeRequired) base.Close();
			else Invoke(new Delegates.VoidResultVoidParams(Close));
		}
	}
}
