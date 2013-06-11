using System;
using CallRecorder.Model;
using CallRecorder.View;
using Ozeki.VoIP;

namespace CallRecorder.Presenter
{
	public class ConnectToServerPresenter
	{
		readonly IConnectToServer view;
		readonly IOPSClient client;
		WaitWindow window;
		readonly object sync;

		public ConnectToServerPresenter(IConnectToServer my_view, IOPSClient my_client)
		{
			sync = new object();
			view = my_view;
			client = my_client;
		}

		~ConnectToServerPresenter()
		{
			CloseWindow();
		}

		public void Connect()
		{
			if (CanConnect) Login();
			else view.ShowError("Connection failed", "Please fill out all fields");
		}

		public void CloseWindow()
		{
			if (window != null) view.CloseWaitWindow(window);
		}

		void Login()
		{
			lock (sync)
			{
				view.SetState(LoginState.LoggingIn);
				window = view.ShowWaitWindow();

				client.LoginCompleted += ClientOnLoginCompleted;
				client.Login(view.Server, view.Username, view.Password);
			}
		}

		void ClientOnLoginCompleted(object sender, VoIPEventArgs<LoginResult> e)
		{
			view.CloseWaitWindow(window);
			view.SetState((e.Item == LoginResult.Success) ? LoginState.LoggingIn : LoginState.LoggedOut);

			if (e.Item != LoginResult.Success)
				view.ShowError("Connection failed", String.Format("Failed to connect to server: {0}", e.Item));
			else
			{
				view.Connected = true;
				view.Close();
			}
			client.LoginCompleted -= ClientOnLoginCompleted;
		}

		bool CanConnect
		{
			get
			{
				return !String.IsNullOrEmpty(view.Server) && !String.IsNullOrEmpty(view.Username) && !String.IsNullOrEmpty(view.Password) && !client.IsLoggedIn;
			}
		}
	}
}
