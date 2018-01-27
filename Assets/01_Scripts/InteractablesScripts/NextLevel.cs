using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

<<<<<<< HEAD:Assets/01_Scripts/InteractablesScripts/NextLevel.cs
public class NextLevel : MonoBehaviour {

	public int sceneTransitionIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
		SceneManager.LoadScene (sceneTransitionIndex);
=======
public class NextLevel : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex%2)+1);
>>>>>>> c4e6adef46cf5b088cf0aee3a0fd4ca6e4e6a87d:Assets/NextLevel.cs
    }
}
