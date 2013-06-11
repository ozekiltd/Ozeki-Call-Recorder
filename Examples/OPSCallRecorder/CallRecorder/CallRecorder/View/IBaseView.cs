using System;

namespace CallRecorder.View
{
	public interface IBaseView
	{
		void ShowInfo(string title, string message);
		void ShowError(Exception ex);
		void ShowError(string title, string message);
		WaitWindow ShowWaitWindow(string message = null);
		void CloseWaitWindow(WaitWindow window);
		void Close();
	}
}
