using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesseractgs.Ugx.Framework {
	public interface IGraphicsDeviceManager {
		bool BeginDraw( );
		void CreateDevice( );
		void EndDraw( );
	}
}
