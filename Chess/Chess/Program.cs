using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess {
	class Program {
		static void Main(string[] args) {
			World world = new World();
			Soldier s = new Soldier(new Tile(5, 5), world);
			world.pawns.Add(s);
			s = new Soldier(new Tile(5, 7), world);
			world.pawns.Add(s);

			world.pawns[0].UpdateMoves();
			
		}
	}
}
