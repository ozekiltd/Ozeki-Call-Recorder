using System.Windows.Forms;
using CallRecorder.Model;

namespace CallRecorder.View
{
	interface IMainWindow : IBaseView
	{
		void SetState(LoginState state);
		void ShowConnectToServerWindow();
		void ShowDetailsOfListViewItem(ListViewItem item);

		string GetSelectedFilename();
	}
}
