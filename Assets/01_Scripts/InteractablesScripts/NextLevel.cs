using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NextLevel : MonoBehaviour {

	public int sceneTransitionIndex;
    public int spawnLocation;
    public Image img;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(FadeImage());
        Init.spawnLocation = spawnLocation;
        StartCoroutine(NextScene());

    }
    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneTransitionIndex);
    }
    IEnumerator FadeImage()
    {
         // loop over 1 second
        for (float i = 0; i <= 1; i += Time.deltaTime)
        { 
            // set color with i as alpha
            img.color = new Color(0, 0, 0, i);
            yield return null;

        }
    }
}
