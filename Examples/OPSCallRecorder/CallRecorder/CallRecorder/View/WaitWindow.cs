using System.Windows.Forms;
using CallRecorder.Util;

namespace CallRecorder.View
{
    public partial class WaitWindow : Form
    {
        bool can_exit;

        public WaitWindow(string message = null)
        {
            InitializeComponent();
            can_exit = false;
            if (message != null) lbl_PleaseWait.Text = message;
        }

        public new void Close()
        {
            if (!InvokeRequired)
            {
                can_exit = true;
                base.Close();
            }
            else Invoke(new Delegates.VoidResultVoidParams(Close));
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (can_exit) base.OnClosing(e);
            else e.Cancel = true;
        }

		private void WaitWindow_Shown(object sender, System.EventArgs e)
		{
			Invalidate();
		}
    }
}
