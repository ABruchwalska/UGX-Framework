using System;

namespace Tesseractgs.Ugx.Framework.Graphics {
	public sealed class NoSuitableGraphicsDeviceException : Exception {
		public NoSuitableGraphicsDeviceException( ) { }

		public NoSuitableGraphicsDeviceException(string message) : base(message) { }

		public NoSuitableGraphicsDeviceException(string message, Exception innerException) : base(message, innerException) { }
	}
}
