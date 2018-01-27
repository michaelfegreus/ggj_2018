using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_script : MonoBehaviour {
    public GameObject textBox;
    public TextAsset textFile;
    public string[] textLines;
    public Text theText;
    public mono_player_interaction player;
    private int currentLine = 0;
	// Use this for initialization
	void Start () {
		if(textFile != null)
        {
            textLines = textFile.text.Split('\n');
            theText.text = textLines[currentLine];
        }
        else
        {
            theText.text = "";
        }
	}

	// Update is called once per frame
	void Update () {
        if (textFile != null)
        {
            textLines = textFile.text.Split('\n');
            theText.text = textLines[currentLine];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                currentLine++;                
            }
            if (currentLine >= textLines.Length)
            {
                player.DeactivateZone();
                NoSignal();
            }
        }
        else
        {
            theText.text = "";
        }
    }
    public void RecieveText(TextAsset t)
    {
        textFile = t;
    }
    public void NoSignal()
    {
        textFile = null;
    }
}
