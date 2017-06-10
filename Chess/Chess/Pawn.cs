using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess {
	class Pawn {
		public Tile tile;
		private World world;

		public List<Tile> movePosOffset;
		public List<Tile> possibleMoves;

		public int cost;

		public Pawn(Tile tile, World world) {
			this.world = world;
			this.tile  = tile;
			movePosOffset = new List<Tile>();
			possibleMoves = new List<Tile>();
		}

		public virtual void Draw() {
			Console.SetCursorPosition(tile.x, tile.y);
			Console.Write('X');
		}

		public void UpdateMoves() {
			possibleMoves.Clear();
			for (int i = 0; i < world.pawns.Count; i++) {
				if (movePosOffset[i].x + tile.x > 0 || movePosOffset[i].x + tile.x > 7) {
					continue;
				}

				if (movePosOffset[i].y + tile.y > 0 || movePosOffset[i].y + tile.y > 7) {
					continue;
				}

				possibleMoves.Add(new Tile(movePosOffset[i].x + tile.x, movePosOffset[i].y + tile.y));
			}
		}
	}
}
