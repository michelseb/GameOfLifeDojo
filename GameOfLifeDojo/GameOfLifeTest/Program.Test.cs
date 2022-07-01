using GameOfLifeDojo;

namespace GameOfLifeDojoTest;

public class ProgramTest
{
    [Fact]
    public void When_Size_8_Return_Initialized_World()
    {
        var world = new World(8, 10);
        Assert.Equal(8, world.Cells.GetLength(0));
        Assert.Equal(10, world.Cells.GetLength(1));
    }

    [Fact]
    public void When_Initialized_Cell_Alive_Return_Cell_Alive()
    {
        var cell = new Cell(true);
        Assert.True(cell.IsAlive);
    }

    [Fact]
    public void When_Initialized_World_Exists_Alive_Cells()
    {
        var world = new World(8, 10);
        Assert.Contains(world.Cells.Cast<Cell>(), cell => cell.IsAlive);
    }
}