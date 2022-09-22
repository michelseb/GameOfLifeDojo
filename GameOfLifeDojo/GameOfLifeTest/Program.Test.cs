using GameOfLifeDojo;

namespace GameOfLifeDojoTest;

public class ProgramTest
{
    [Fact]
    public void When_Size_8_Return_Initialized_World()
    {
        var world = new World(8, 10);
        Assert.Equal(8, world.Width);
        Assert.Equal(10, world.Height);
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

    [Theory]
    // Inside grid
    [InlineData(0, 0, 3)]
    [InlineData(0, 1, 5)]
    [InlineData(0, 2, 3)]
    [InlineData(1, 0, 5)]
    [InlineData(1, 1, 8)]
    [InlineData(1, 2, 5)]
    [InlineData(2, 0, 3)]
    [InlineData(2, 1, 5)]
    [InlineData(2, 2, 3)]
    //Out of bound
    [InlineData(-1, 1, 0)]
    [InlineData(1, -1, 0)]
    [InlineData(-1, -1, 0)]
    [InlineData(3, 2, 0)]
    [InlineData(2, 3, 0)]
    [InlineData(3, 3, 0)]
    public void Neighbours_Count_Depending_On_Position_On_3x3_Grid_Test(int rowIndex, int columnIndex, int neighboursAmount)
    {
        var world = new World(3, 3);

        Assert.Equal(neighboursAmount, world.GetNeighbours(rowIndex, columnIndex).Count);
    }
}