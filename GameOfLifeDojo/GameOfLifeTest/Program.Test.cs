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
    public void When_Initialized_Cell_Dead_Return_Cell_Dead()
    {
        var cell = new Cell(false);
        Assert.False(cell.IsAlive);
    }

    [Fact]
    public void When_Initialized_World_Exists_Alive_Cells()
    {
        var world = new World(8, 10);
        Assert.Contains(world.Cells.Cast<Cell>(), cell => cell.IsAlive);
    }

    [Theory]
    [InlineData(0, 0, 3)]
    [InlineData(0, 1, 5)]
    [InlineData(0, 2, 3)]
    [InlineData(1, 0, 5)]
    [InlineData(1, 1, 8)]
    [InlineData(1, 2, 5)]
    [InlineData(2, 0, 3)]
    [InlineData(2, 1, 5)]
    [InlineData(2, 2, 3)]
    public void When_Cell_Stands_In_The_Middle_Of_a_Grid_It_Should_Have_Neighbours(int x, int y, int neighbourAmount)
    {
        var world = new World(3, 3);
        Assert.Equal(neighbourAmount, world.GetAliveNeighboursForCell(x, y).Count());
    }
}