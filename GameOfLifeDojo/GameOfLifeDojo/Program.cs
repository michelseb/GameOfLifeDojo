using System.Text;

namespace GameOfLifeDojo;

static class Program
{
    private const int ROW_AMOUNT = 20;
    private const int COLUMN_AMOUNT = 40;
    private const int SCREEN_REFRESH_DELAY = 500;

    public static void Main()
    {
        var grid = new World(ROW_AMOUNT, COLUMN_AMOUNT);

        Console.Clear();

        while (true)
        {
            Display(grid, SCREEN_REFRESH_DELAY);
        }
    }

    private static void Display(World world, int delay)
    {
        var stringBuilder = new StringBuilder();

        for (var i = 0; i < world.Width; i++)
        {
            stringBuilder.Append("|");

            for (var j = 0; j < world.Height; j++)
            {
                var cell = world.GetCellAt(i, j);

                if (cell == null)
                    throw new Exception("Cell does not exist");

                stringBuilder.Append(cell.IsAlive ? "0|" : " |");
            }

            stringBuilder.Append("\n");

            for (var j = 0; j < world.Height * 2; j++)
            {
                stringBuilder.Append("-");
            }

            stringBuilder.Append("\n");
        }

        Console.BackgroundColor = ConsoleColor.Black;
        Console.CursorVisible = false;
        Console.SetCursorPosition(0, 0);
        Console.Write(stringBuilder.ToString());

        // Delay before we refresh the screen display
        Thread.Sleep(delay);
    }
}
