using System;

namespace Tesseractgs.Ugx.Framework.Graphics {
	public sealed class DeviceLostException : Exception {
		public DeviceLostException( ) { }

		public DeviceLostException(string message) : base(message) { }

		public DeviceLostException(string message, Exception innerException) : base(message, innerException) { }
	}
}
