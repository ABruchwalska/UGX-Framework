using System;

namespace Tesseractgs.Ugx.Framework.Audio {
	public sealed class InstancePlayLimitException : Exception {
		public InstancePlayLimitException( ) { }

		public InstancePlayLimitException(string message) : base(message) { }

		public InstancePlayLimitException(string message, Exception innerException) : base(message, innerException) { }
	}
}
