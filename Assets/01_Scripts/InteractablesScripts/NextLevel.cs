﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour {

	public int sceneTransitionIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
		SceneManager.LoadScene (sceneTransitionIndex);
    }
}
