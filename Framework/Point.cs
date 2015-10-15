using System;
using System.Globalization;

namespace Tesseractgs.Ugx.Framework {
	public struct Point : IEquatable<Point> {
		public int X;
		public int Y;

		public Point(int x, int y) {
			this.X = x;
			this.Y = y;
		}

		public override bool Equals(object obj) {
			if (obj is Point) {
				var other = (Point)obj;
				return this.X == other.X
					&& this.Y == other.Y;
			} else {
				return false;
			}
		}

		public bool Equals(Point other) => this.X == other.X && this.Y == other.Y;

		public override int GetHashCode( ) => this.X.GetHashCode( ) + this.Y.GetHashCode( );

		public override string ToString( ) => string.Format(CultureInfo.CurrentCulture, "{{X:{0} Y:{1}}}", this.X, this.Y);

		public static bool operator !=(Point a, Point b) => a.X != b.X || a.Y != b.Y;

		public static bool operator ==(Point a, Point b) => a.X == b.X && a.Y == b.Y;

		public static Point Zero => _zero;

		static Point( ) {
			_zero = new Point(0, 0);
		}

		private static readonly Point _zero;
	}
}
