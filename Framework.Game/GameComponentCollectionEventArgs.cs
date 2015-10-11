using System;

namespace Tesseractgs.Ugx.Framework {
	public class GameComponentCollectionEventArgs : EventArgs {
		public GameComponentCollectionEventArgs(IGameComponent gameComponent) {
			GameComponent = gameComponent;
		}

		public IGameComponent GameComponent { get; private set; }
	}
}
