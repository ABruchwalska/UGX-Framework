using System;

namespace Tesseractgs.Ugx.Framework.Graphics {
	public sealed class ResourceCreatedEventArgs : EventArgs {
		internal ResourceCreatedEventArgs(object resource) {
			Resource = resource;
		}

		public object Resource { get; private set; }
	}
}
