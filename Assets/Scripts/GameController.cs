using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LevelController))]
[RequireComponent(typeof(Visuals))]
public class GameController : MonoBehaviour
{
    [HideInInspector]
    public GameState state;
    private LevelsConfig levelsConfig;
    private LevelController levelCtrl;
    private Visuals visualsCtrl;
    private int currentLevel;
    private int levelsCount;


    private void Start()
    {
        state = GameState.Title;
        levelsConfig = new LevelsConfig();
        levelCtrl = GetComponent<LevelController>();
        visualsCtrl = GetComponent<Visuals>();
        currentLevel = 0;
        levelsCount = levelsConfig.levels.Count;
    }

    private void Update()
    {
        Inputs currentInput = InputHandle();
        if (currentInput != Inputs.None)
        {
            switch (state)
            {
                case GameState.Title:
                    {
                        if (currentInput == Inputs.Enter)
                        {
                            state = GameState.Game;
                            LoadLevel();
                        }
                        break;
                    }
                case GameState.Game:
                    {
                        switch (currentInput)
                        {
                            case Inputs.Next:
                                {
                                    if (currentLevel < levelsCount - 1)
                                    {
                                        DestroyLevel();
                                        currentLevel++;
                                        LoadLevel();
                                    }
                                    break;
                                }
                            case Inputs.Previous:
                                {
                                    if (currentLevel > 0)
                                    {
                                        DestroyLevel();
                                        currentLevel--;
                                        LoadLevel();
                                    }
                                    break;
                                }
                            case Inputs.Restart:
                                {
                                    DestroyLevel();
                                    LoadLevel();
                                    break;
                                }
                            case Inputs.Enter:
                                {
                                    break;
                                }
                            default:
                                {
                                    levelCtrl.TheseusAct(currentInput);
                                    break;
                                }
                        }
                        break;
                    }
                case GameState.Loose:
                    {
                        if (currentInput == Inputs.Enter)
                        {
                            state = GameState.Game;
                            LoadLevel();
                        }
                        break;
                    }
            }
        }
    }

    private void LoadLevel()
    {
        levelCtrl.LoadLevel(levelsConfig.levels[currentLevel]);
        visualsCtrl.LoadVisuals(levelCtrl);

        LevelController.onWin += WinLevel;
        LevelController.onLoose += LooseLevel;
    }
    private void DestroyLevel()
    {
        visualsCtrl.DestroyVisuals();

        LevelController.onWin -= WinLevel;
        LevelController.onLoose -= LooseLevel;
    }

    private void WinLevel()
    {
        if (currentLevel < levelsCount - 1)
        {
            DestroyLevel();
            currentLevel++;
            LoadLevel();
        }
        else
        {
            DestroyLevel();
            state = GameState.Title;
        }
    }
    private void LooseLevel()
    {
        DestroyLevel();
        state = GameState.Loose;
    }

    private Inputs InputHandle()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            return Inputs.Up;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            return Inputs.Right;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            return Inputs.Down;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            return Inputs.Left;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            return Inputs.Wait;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            return Inputs.Next;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            return Inputs.Previous;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            return Inputs.Restart;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            return Inputs.Enter;
        }
        return Inputs.None;
    }
}
