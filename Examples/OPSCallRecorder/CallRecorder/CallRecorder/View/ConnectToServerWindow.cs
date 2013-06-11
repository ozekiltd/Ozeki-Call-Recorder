using System;
using CallRecorder.Model;
using CallRecorder.Presenter;
using CallRecorder.Util;

namespace CallRecorder.View
{
    public partial class ConnectToServerWindow : BaseWindow, IConnectToServer
	{
        readonly ConnectToServerPresenter presenter;

		public ConnectToServerWindow()
		{
			InitializeComponent();
            presenter = new ConnectToServerPresenter(this, SimpleIOCContainer.Instance.Resolve<IOPSClient>());
		}

		public string Server
		{
			get { return tb_Server.Text; }
		}

		public string Username
		{
			get { return tb_Username.Text; }
		}

		public string Password
		{
			get { return tb_Password.Text; }
		}

        public bool Connected { get; set; }

        public void ConnectClicked(object sender, EventArgs e)
        {
			presenter.Connect();
		}

        public void CloseClicked(object sender, EventArgs e)
        {
            Close();
        }

        public void SetState(LoginState state)
        {
            if (!InvokeRequired)
            {
                switch (state)
                {
                    case LoginState.LoggedOut:
                        btn_Connect.Enabled = true;
                        break;
                    case LoginState.LoggingIn:
                    case LoginState.LoggedIn:
                        btn_Connect.Enabled = false;
						//btn_Cancel.Enabled = false;
                        break;
                }
            }
            else Invoke(new Delegates.VoidResultLoginStateParams(SetState), state);
        }

		void ConnectToServerWindow_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			presenter.CloseWindow();
		}
	}
}
