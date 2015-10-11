using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesseractgs.Ugx.Framework.Audio {
	[Obsolete("XACT is no more supported. Use Tesseractgs.Ugx.Framework.Audio.dll", true)]
	public class AudioEngine : IDisposable {
		#region IDisposable Members

		public void Dispose( ) {
			throw new NotImplementedException( );
		}

		#endregion
	}
}
