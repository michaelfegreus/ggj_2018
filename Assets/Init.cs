using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Init : MonoBehaviour
{
    public static Init instance = null;
    private static bool first = true;
    public static int num_scenes = 3;
    public static int[] events = { 0, 1, 1 };
    public static int spawnLocation = 0;
    public static bool[][] activezones = new bool[num_scenes][];

    private void Awake()
    {
        FirstRun();
        for (int j = 0; j < events[SceneManager.GetActiveScene().buildIndex]; j++)
        {
            if (!activezones[SceneManager.GetActiveScene().buildIndex][j])
            {
                GameObject.Find("CellZone" + j).SetActiveRecursively(false);
            }
        }
    }
    void FirstRun()
    {
        if (first)
        {
            for (int i = 0; i < num_scenes; i++)
            {
                activezones[i] = new bool[events[i]];
                for (int j = 0; j < events[i]; j++)
                {
                    activezones[i][j] = true;
                }
            }
            first = false;
        }

    }
}