using System;

namespace Tesseractgs.Ugx.Framework.Media {
	[Flags]
	public enum VideoSoundtrackType : byte {
		Music = 1,
		Dialog = 2,
		MusicAndDialog = 3,
	}
}
