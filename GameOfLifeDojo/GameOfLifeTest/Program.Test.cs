using GameOfLifeDojo;

namespace GameOfLifeDojoTest;

public class ProgramTest
{
    public void When_Size_8_Return_Initialized_World()
    {
        var world = new World(8, 8);
        Assert.Equal(8, world.Rows.Count);
        Assert.Equal(8, world.Columns.Count);
    }
}