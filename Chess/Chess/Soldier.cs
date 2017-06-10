using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess {
	class Soldier : Pawn {
		public Soldier(Tile tile, World world) : base(tile, world) {
			movePosOffset.Add(new Tile(0, 1));
			movePosOffset.Add(new Tile(0, 2));
			cost = 5;
		}
	}
}
