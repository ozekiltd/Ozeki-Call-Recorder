using CallRecorder.Model;

namespace CallRecorder.View
{
	public interface IConnectToServer : IBaseView
	{
		string Server { get; }
		string Username { get; }
		string Password { get; }
		bool Connected { get; set; }

		void SetState(LoginState state);
	}
}
