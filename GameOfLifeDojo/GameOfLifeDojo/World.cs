namespace GameOfLifeDojo
{
    public class World
    {
        /// <summary>
        /// Each cell has this much probability to be alive at initialization
        /// </summary>
        private const float LIFE_PROBABILITY = .3f;

        public World(int rowCount, int columnCount)
        {
            _cells = new Cell[rowCount, columnCount];

            Initializer(rowCount, columnCount);
        }

        private void Initializer(int rowCount, int columnCount)
        {
            var random = new Random();

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    var isAlive = random.NextDouble() < LIFE_PROBABILITY;
                    Cell cell = new Cell(isAlive);
                    _cells[i, j] = cell;
                }
            }
        }

        private Cell[,] _cells;

        public int? Width => _cells?.GetLength(0);
        public int? Height => _cells?.GetLength(1);

        public Cell? GetCellAt(int rowIndex, int columnIndex)
        {
            if (rowIndex < 0 || rowIndex >= Width || columnIndex < 0 || columnIndex >= Height)
                return null;

            return _cells[rowIndex, columnIndex];
        }

        public IList<Cell> GetNeighbours(int rowIndex, int columnIndex)
        {
            var result = new List<Cell>();

            // If cell is outside of grid, we don't process its neighbours
            if (GetCellAt(rowIndex, columnIndex) == null)
                return result;

            for (var i = rowIndex - 1; i <= rowIndex + 1; i++)
            {
                for (var j = columnIndex - 1; j <= columnIndex + 1; j++)
                {
                    // We don't want current cell to be considered a neighbour
                    if (i == rowIndex && j == columnIndex)
                        continue;

                    var neighbour = GetCellAt(i, j);

                    if (neighbour != null)
                        result.Add(neighbour);
                }
            }

            return result;
        }
    }
}