using System.Collections.Generic;
using UnityEngine;

public class Visuals : MonoBehaviour
{
    private LevelController level;
    private List<GameObject> environment;
    private GameObject theseus;
    private GameObject minotaur;

    public GameObject prefab_panel;
    public GameObject prefab_wall;
    public GameObject prefab_theseus;
    public GameObject prefab_minotaur;
    public GameObject prefab_exit;

    public void LoadVisuals(LevelController levelController)
    {
        level = levelController;
        int mazeWidth = level.maze.GetLength(0);
        int mazeHeight = level.maze.GetLength(1);
        environment = new List<GameObject>();

        for (int i = 0; i < mazeWidth; i++)
        {
            for (int j = 0; j < mazeHeight; j++)
            {
                environment.Add(Instantiate(prefab_panel, new Vector3(i, j, 0), Quaternion.identity));
                if (!level.maze[i, j].LinkN)
                {
                    environment.Add(Instantiate(prefab_wall, new Vector3(i, j + 0.45f, -0.1f), Quaternion.identity));
                }
                if (!level.maze[i, j].LinkE)
                {
                    environment.Add(Instantiate(prefab_wall, new Vector3(i + 0.45f, j, -0.1f), Quaternion.Euler(0, 0, 90)));
                }
                if (!level.maze[i, j].LinkS)
                {
                    environment.Add(Instantiate(prefab_wall, new Vector3(i, j - 0.45f, -0.1f), Quaternion.identity));
                }
                if (!level.maze[i, j].LinkW)
                {
                    environment.Add(Instantiate(prefab_wall, new Vector3(i - 0.45f, j, -0.1f), Quaternion.Euler(0, 0, 90)));
                }
            }
        }

        environment.Add(Instantiate(prefab_exit, new Vector3(level.exitX, level.exitY, -0.2f), Quaternion.identity));
        theseus = Instantiate(prefab_theseus, new Vector3(level.theseusX, level.theseusY, -0.25f), Quaternion.identity);
        minotaur = Instantiate(prefab_minotaur, new Vector3(level.minotaurX, level.minotaurY, -0.3f), Quaternion.identity);
    }

    private void Update()
    {
        if (theseus != null && minotaur != null)
        {
            theseus.transform.position = new Vector3(level.theseusX, level.theseusY, -0.25f);
            minotaur.transform.position = new Vector3(level.minotaurX, level.minotaurY, -0.3f);
        }
    }

    public void DestroyVisuals()
    {
        foreach (GameObject o in environment)
        {
            Destroy(o);
        }
        Destroy(theseus);
        Destroy(minotaur);
    }
}
