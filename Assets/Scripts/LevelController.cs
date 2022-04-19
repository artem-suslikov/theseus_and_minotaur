using UnityEngine;

public class LevelController : MonoBehaviour
{
    public Cell[,] maze { get; set; }
    public int exitX { get; set; }
    public int exitY { get; set; }
    public int theseusX { get; set; }
    public int theseusY { get; set; }
    public int minotaurX { get; set; }
    public int minotaurY { get; set; }

    private bool theseusTurn = true;
    private int minotaurTurns = 2;

    public void LoadLevel(Level levelConfig)
    {
        maze = levelConfig.maze;
        exitX = levelConfig.exitX;
        exitY = levelConfig.exitY;
        theseusX = levelConfig.theseusX;
        theseusY = levelConfig.theseusY;
        minotaurX = levelConfig.minotaurX;
        minotaurY = levelConfig.minotaurY;
    }

    private void Update()
    {
        if (theseusX == exitX && theseusY == exitY)
        {
            Win();
        }

        if (theseusX == minotaurX && theseusY == minotaurY)
        {
            Loose();
        }

        if (!theseusTurn)
        {
            MinotaurAct();
        }
    }
    public void TheseusAct(Inputs input)
    {
        if (theseusTurn)
        {
            switch (input)
            {
                case Inputs.Up:
                    {
                        if (maze[theseusX, theseusY].LinkN)
                        {
                            theseusY++;
                            theseusTurn = false;
                            minotaurTurns = 2;
                        }
                        break;
                    }
                case Inputs.Right:
                    {
                        if (maze[theseusX, theseusY].LinkE)
                        {
                            theseusX++;
                            theseusTurn = false;
                            minotaurTurns = 2;
                        }
                        break;
                    }
                case Inputs.Down:
                    {
                        if (maze[theseusX, theseusY].LinkS)
                        {
                            theseusY--;
                            theseusTurn = false;
                            minotaurTurns = 2;
                        }
                        break;
                    }
                case Inputs.Left:
                    {
                        if (maze[theseusX, theseusY].LinkW)
                        {
                            theseusX--;
                            theseusTurn = false;
                            minotaurTurns = 2;
                        }
                        break;
                    }
                case Inputs.Wait:
                    {
                        theseusTurn = false;
                        minotaurTurns = 2;
                        break;
                    }
            }
        }
    }
    public void MinotaurAct()
    {
        if (minotaurTurns > 0)
        {
            bool minotaurStuck = true;

            if (theseusX != minotaurX)
            {
                if (theseusX > minotaurX)
                {
                    if (maze[minotaurX, minotaurY].LinkE)
                    {
                        minotaurX++;
                        minotaurTurns--;
                        minotaurStuck = false;
                    }
                }
                if (theseusX < minotaurX)
                {
                    if (maze[minotaurX, minotaurY].LinkW)
                    {
                        minotaurX--;
                        minotaurTurns--;
                        minotaurStuck = false;
                    }
                }
            }
            if (minotaurStuck)
            {
                if (theseusY < minotaurY)
                {
                    if (maze[minotaurX, minotaurY].LinkS)
                    {
                        minotaurY--;
                        minotaurTurns--;
                        minotaurStuck = false;
                    }
                }
                if (theseusY > minotaurY)
                {
                    if (maze[minotaurX, minotaurY].LinkN)
                    {
                        minotaurY++;
                        minotaurTurns--;
                        minotaurStuck = false;
                    }
                }
            }

            if (minotaurStuck) 
            {
                minotaurTurns = 0; 
            }
        }
        else
        {
            theseusTurn = true;  
        }
    }

    public delegate void OnStateChange();
    public static event OnStateChange onWin;
    public static event OnStateChange onLoose;

    private void Win()
    {
        onWin?.Invoke();
    }

    private void Loose()
    {
        onLoose?.Invoke();
    }
}
