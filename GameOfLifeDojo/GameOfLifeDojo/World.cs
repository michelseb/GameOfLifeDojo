namespace GameOfLifeDojo
{
    public class World
    {
        public World(int rowCount, int columnCount)
        {
            Cells = new Cell[rowCount, columnCount];

            Initializer(rowCount, columnCount);
        }

        private void Initializer(int rowCount, int columnCount)
        {
            var random = new Random();

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    var isAlive = random.NextDouble() < 0.5;
                    Cell cell = new Cell(isAlive);
                    this.Cells[i, j] = cell;
                }
            }
        }

        public Cell[,] Cells { get; private set; }
    }
}