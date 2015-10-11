using System;

namespace Tesseractgs.Ugx.Framework.Audio {
	public sealed class NoAudioHardwareException : Exception {
		public NoAudioHardwareException( ) { }

		public NoAudioHardwareException(string message) : base(message) { }

		public NoAudioHardwareException(string message, Exception innerException) : base(message, innerException) { }
	}
}
