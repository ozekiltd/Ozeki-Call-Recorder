using Ozeki.Media;
using Ozeki.Media.MediaHandlers;

namespace CallRecorder.Model
{
	class ConnectorContext
	{
		public MediaConnector Connector { get; private set; }
		public AudioMixerMediaHandler Mixer { get; private set; }

		public ConnectorContext(MediaConnector connector, AudioMixerMediaHandler mixer)
		{
			Connector = connector;
			Mixer = mixer;
		}
	}
}
