using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour {
    public Text tutorial;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Init.end = true;
        tutorial.gameObject.SetActive(true);
    }
}
