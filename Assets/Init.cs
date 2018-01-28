using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Init : MonoBehaviour
{
    public static Init instance = null;
    public static bool first = true;
    public static int num_scenes = 6;
    public static int[] events = { 0, 2, 2, 4, 0, 6, 1}; // Title, House, etc...
    public static int spawnLocation = 0;
    public static bool[][] activezones = new bool[num_scenes][];
    public Image img;
    public static bool end = false;

    private void Awake()
    {
        print(end);
        FirstRun();
        StartCoroutine(FadeImage());
        if (end)
        {
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                GameObject.Find("CellZone" + 2).SetActiveRecursively(true);
            }
            for (int j = 0; j < events[SceneManager.GetActiveScene().buildIndex]; j++)
            {
                GameObject.Find("CellZone" + j).SetActiveRecursively(false);
            }
        }
        else
        {
            for (int j = 0; j < events[SceneManager.GetActiveScene().buildIndex]; j++)
            {
                if (!activezones[SceneManager.GetActiveScene().buildIndex][j])
                {
                    GameObject.Find("CellZone" + j).SetActiveRecursively(false);
                }
            }
        }
        
    }
    IEnumerator FadeImage()
    {
        // loop over 1 second backwards
        for (float i = 1; i >= 0; i -= Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(0, 0, 0, i);
            yield return null;
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
