namespace GameOfLifeDojoTest;

public class ProgramTest
{
    [Fact]
    public void When_True_Should_Return_Truthy()
    {
        Assert.True(true);
    }

    public void When_Size_8_Return_Initialized_World()
    {
        var world = new World(8, 8);
        Assert.Equal(8 * 8, world.Cells.Count);
    }
}