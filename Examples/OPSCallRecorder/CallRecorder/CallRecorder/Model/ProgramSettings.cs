using System.Collections.Generic;

namespace CallRecorder.Model
{
	public class ProgramSettings
	{
		public ProgramSettings() { }

		public List<string> RecordableExtensions { get; set; }
		public List<string> RecordableOutsideLines { get; set; }
		public string RecordingPath { get; set; }
		public RecordingFileFormat RecordingFileFormat { get; set; }
	}
}
