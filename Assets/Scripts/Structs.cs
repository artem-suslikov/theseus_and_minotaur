public struct Cell
{
    public bool LinkN { get; }
    public bool LinkE { get; }
    public bool LinkS { get; }
    public bool LinkW { get; }

    public Cell(bool north, bool east, bool south, bool west)
    {
        LinkN = north;
        LinkE = east;
        LinkS = south;
        LinkW = west;
    }
}

public struct Level
{
    public Cell[,] maze { get; }
    public int exitX { get; }
    public int exitY { get; }
    public int theseusX { get; }
    public int theseusY { get; }
    public int minotaurX { get; }
    public int minotaurY { get; }

    public Level(Cell[,] mazeGrid, int exX, int exY, int thX, int thY, int mnX, int mnY)
    {
        maze = mazeGrid;
        exitX = exX;
        exitY = exY;
        theseusX = thX;
        theseusY = thY;
        minotaurX = mnX;
        minotaurY = mnY;
    }
}
