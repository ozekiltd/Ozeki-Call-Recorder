using System;
using System.Collections.Generic;
using OPSSDK;
using OPSSDKCommon.Model.Extension;
using Ozeki.VoIP;

namespace CallRecorder.Model
{
	public interface IOPSClient
	{
		bool IsLoggedIn { get; }
		void Login(string server_address, string username, string password);
		void Logout();

		event EventHandler<VoIPEventArgs<LoginResult>> LoginCompleted;
		event EventHandler<VoIPEventArgs<ISession>> SessionCompleted;
		event EventHandler<VoIPEventArgs<ISession>> SessionCreated;
		event EventHandler<VoIPEventArgs<ErrorInfo>> ErrorOccurred;

		List<ExtensionInfo> ExtensionInfos { get; }
		void GetExtensionInfosAsync(Action<List<ExtensionInfo>> completed);

		IAPIExtension GetAPIExtension(string extension_name);
		void GetAPIExtensionAsync(string extension_name, Action<IAPIExtension> completed);
	}
}
