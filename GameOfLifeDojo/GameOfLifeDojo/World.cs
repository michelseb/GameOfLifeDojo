namespace GameOfLifeDojo
{
    public class World
    {
        public World(int rowCount, int columnCount) {
            Cells = new Cell[rowCount, columnCount];
            
            Initializer(rowCount, columnCount);
        }

        private void Initializer(int rowCount, int columnCount)
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Cell cell = new Cell();
                    this.Cells[i, j] = cell;
                }
            }
        }

        public Cell[,] Cells { get; private set; } 

    }
}
