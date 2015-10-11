using System;

namespace Tesseractgs.Ugx.Framework.Graphics {
	public sealed class DeviceNotResetException : Exception {
		public DeviceNotResetException( ) { }

		public DeviceNotResetException(string message) : base(message) { }

		public DeviceNotResetException(string message, Exception innerException) : base(message, innerException) { }
	}
}
