using System;
using System.Windows.Forms;
using CallRecorder.Model;
using CallRecorder.Util;
using CallRecorder.View;
using OzCommon.Model;

namespace CallRecorder
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			SimpleIOCContainer.Instance.AddDependency<IOPSClient>(() => new RealClient());
			SimpleIOCContainer.Instance.AddDependency<IGenericSettingsRepository<ProgramSettings>>(() => new GenericSettingsRepository<ProgramSettings>());
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}
	}
}
