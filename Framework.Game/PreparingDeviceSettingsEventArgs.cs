using System;

namespace Tesseractgs.Ugx.Framework {
	public class PreparingDeviceSettingsEventArgs : EventArgs {
		public PreparingDeviceSettingsEventArgs(GraphicsDeviceInformation graphicsDeviceInformation) {
			GraphicsDeviceInformation = graphicsDeviceInformation;
		}

		public GraphicsDeviceInformation GraphicsDeviceInformation { get; private set; }
	}
}
