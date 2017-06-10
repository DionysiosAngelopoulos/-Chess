using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess {
	class World {
		public List<Pawn> pawns;

		public World() {
			pawns = new List<Pawn>();
		}

		public void Draw() {
			foreach(Pawn pawn in pawns) {
				pawn.Draw();
			}
		}
		
		public void Move(Pawn pawn, Tile tile) {
			pawn.tile = tile;
			for (int i = 0; i < pawns.Count; i++) {
				if (pawns[i].tile.x == tile.x && pawns[i].tile.y == tile.y) {
					pawns.RemoveAt(i);
					break;
				}
			}
		}
	}
}
