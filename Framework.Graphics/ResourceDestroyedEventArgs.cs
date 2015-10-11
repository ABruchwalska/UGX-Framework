using System;

namespace Tesseractgs.Ugx.Framework.Graphics {
	public sealed class ResourceDestroyedEventArgs : EventArgs {
		internal ResourceDestroyedEventArgs(string name, object tag) {
			Name = name;
			Tag = tag;
		}

		public string Name { get; private set; }

		public object Tag { get; private set; }
	}
}
