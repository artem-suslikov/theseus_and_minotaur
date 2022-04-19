using System.Collections.Generic;
public class LevelsConfig 
{
    public List<Level> levels;

    public LevelsConfig()
    {
        levels = new List<Level>();
        Cell[,] _m = new Cell[8, 8];


        _m = new Cell[,]
        {
            { new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, false, true, true), new Cell(true, false, true, true), new Cell(true, false, true, true), new Cell(true, true, true, true)},
            { new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(false, true, true, true), new Cell(true, true, false, false), new Cell(true, true, true, false), new Cell(false, true, true, false), new Cell(true, true, false, true)},
            { new Cell(true, true, true, true), new Cell(true, false, true, true), new Cell(true, false, true, true), new Cell(false, false, true, true), new Cell(true, true, false, true), new Cell(true, true, true, true), new Cell(false, true, true, true), new Cell(true, true, false, true)},
            { new Cell(false, true, true, true), new Cell(true, true, false, false), new Cell(true, false, true, false), new Cell(true, true, true, false), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(false, true, true, true), new Cell(true, true, false, true)},
            { new Cell(false, true, true, true), new Cell(false, true, false, true), new Cell(true, false, false, false), new Cell(true, true, true, true), new Cell(false, false, true, true), new Cell(true, false, false, true), new Cell(false, true, true, true), new Cell(true, true, false, true)},
            { new Cell(false, true, true, true), new Cell(true, false, false, true), new Cell(true, true, true, false), new Cell(true, false, true, true), new Cell(true, true, true, false), new Cell(false, false, true, false), new Cell(false, true, false, true), new Cell(true, true, false, true)},
            { new Cell(true, true, true, true), new Cell(false, true, true, false), new Cell(false, true, false, true), new Cell(false, true, false, false), new Cell(true, false, false, true), new Cell(true, false, true, false), new Cell(false, false, true, true), new Cell(true, true, false, true)},
            { new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, false), new Cell(true, true, true, false), new Cell(true, true, true, false), new Cell(true, true, true, true)}
        };
        levels.Add(new Level(_m, 6, 2, 2, 5, 6, 5));

         _m = new Cell[,]
        {
            { new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, false, true, true), new Cell(true, false, true, true), new Cell(true, false, true, true), new Cell(true, true, true, true)},
            { new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(false, true, true, true), new Cell(true, true, false, false), new Cell(true, true, true, false), new Cell(false, true, true, false), new Cell(true, true, false, true)},
            { new Cell(true, true, true, true), new Cell(true, false, true, true), new Cell(true, false, true, true), new Cell(false, false, true, true), new Cell(true, true, false, true), new Cell(true, true, true, true), new Cell(false, true, true, true), new Cell(true, true, false, true)},
            { new Cell(false, true, true, true), new Cell(true, true, false, false), new Cell(true, true, true, false), new Cell(true, true, true, false), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(false, true, true, true), new Cell(true, true, false, true)},
            { new Cell(false, true, true, true), new Cell(true, true, false, true), new Cell(false, false, true, true), new Cell(true, true, false, true), new Cell(false, false, true, true), new Cell(true, false, false, true), new Cell(false, true, true, true), new Cell(true, true, false, true)},
            { new Cell(false, true, true, true), new Cell(true, false, false, true), new Cell(true, true, true, false), new Cell(true, false, true, true), new Cell(true, true, true, false), new Cell(false, false, true, false), new Cell(false, true, false, true), new Cell(true, true, false, true)},
            { new Cell(true, true, true, true), new Cell(false, true, true, false), new Cell(false, true, false, true), new Cell(false, true, false, false), new Cell(true, false, false, true), new Cell(true, false, true, false), new Cell(false, false, true, true), new Cell(true, true, false, true)},
            { new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, false), new Cell(true, true, true, false), new Cell(true, true, true, false), new Cell(true, true, true, true)}
        };
        levels.Add(new Level(_m, 6, 2, 5, 6, 4, 1));

        _m = new Cell[,]
{
            { new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, false, true, true), new Cell(true, false, true, true), new Cell(true, false, true, true), new Cell(true, true, true, true)},
            { new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(false, true, true, true), new Cell(true, true, false, false), new Cell(true, true, true, false), new Cell(false, true, true, false), new Cell(true, true, false, true)},
            { new Cell(true, true, true, true), new Cell(true, false, true, true), new Cell(true, false, true, true), new Cell(false, false, true, true), new Cell(true, true, false, true), new Cell(true, true, true, true), new Cell(false, true, true, true), new Cell(true, true, false, true)},
            { new Cell(false, true, true, true), new Cell(true, true, false, false), new Cell(true, false, true, false), new Cell(true, true, true, false), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(false, true, true, true), new Cell(true, true, false, true)},
            { new Cell(false, true, true, true), new Cell(false, true, false, true), new Cell(true, false, false, false), new Cell(true, true, true, true), new Cell(false, false, true, true), new Cell(true, false, false, true), new Cell(false, true, true, true), new Cell(true, true, false, true)},
            { new Cell(false, true, true, true), new Cell(true, false, false, true), new Cell(true, true, true, false), new Cell(true, false, true, true), new Cell(true, true, true, false), new Cell(true, true, true, false), new Cell(false, true, true, true), new Cell(true, true, false, true)},
            { new Cell(true, true, true, true), new Cell(false, true, true, false), new Cell(false, true, false, true), new Cell(false, true, false, false), new Cell(true, false, false, true), new Cell(true, false, true, true), new Cell(false, false, true, true), new Cell(true, true, false, true)},
            { new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, true), new Cell(true, true, true, false), new Cell(true, true, true, false), new Cell(true, true, true, false), new Cell(true, true, true, true)}
};
        levels.Add(new Level(_m, 6, 2, 4, 4, 5, 4));
    }
}
