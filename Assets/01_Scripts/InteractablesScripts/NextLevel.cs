using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour {

	public int sceneTransitionIndex;
    public int spawnLocation;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Init.spawnLocation = spawnLocation;
        SceneManager.LoadScene (sceneTransitionIndex);
    }
}
