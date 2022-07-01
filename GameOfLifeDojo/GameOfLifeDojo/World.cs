using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeDojo
{
    public class World
    {
        public World(int rowCount, int columnCount) {
            Rows = new List<Cell>(rowCount);
            Columns = new List<Cell>(columnCount);
        }

        public IList<Cell> Rows { get; private set; } 
        public IList<Cell> Columns { get; private set; }
    }
}
