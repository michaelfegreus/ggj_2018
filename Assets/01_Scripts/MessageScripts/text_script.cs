using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XInputDotNetPure;

public class text_script : MonoBehaviour {
    public GameObject textBox;
    public TextAsset textFile;
    public string[] textLines;
    public Text theText;
    public mono_player_interaction player;
    private int currentLine = 0;
    public bool notify = true;
	private int zoneNum;
    public float textActiveTime;
	// Use this for initialization
	void Start () {
		if(textFile != null)
        {
            //textLines = textFile.text.Split('\n');
			textBox.SetActive(true);
            theText.text = textFile.text;
            StartCoroutine(DisplayText());
        }
        else
        {
			textBox.SetActive(false);
            theText.text = "";
        }
	}

	// Update is called once per frame
	void Update () {
        if (textFile != null)
        {
            //textLines = textFile.text.Split('\n');
            //textLines[0] = textFile.text;
            //theText.text = textLines[currentLine];
			textBox.SetActive(true);
			print ("diplay");
            theText.text = textFile.text;
            StartCoroutine(DisplayText());
            StartCoroutine(Notify());
            if (Input.GetKeyDown(KeyCode.Return))
            {
                currentLine++;                
            }
            if (currentLine >= 1)
            {
				player.DeactivateZone(zoneNum);
                NoSignal();
            }
        }
        else
        {
            theText.text = "";
        }
    }
    IEnumerator Notify()
    {
        if (notify)
        {
            notify = false;
            GamePad.SetVibration(PlayerIndex.One, 1.0f, 1.0f);
            yield return new WaitForSeconds(0.2f);
            GamePad.SetVibration(PlayerIndex.One, 0.0f, .0f);
        }
    }
    IEnumerator DisplayText()
    {
		int z = zoneNum;
        yield return new WaitForSeconds(textActiveTime);
        player.DeactivateZone(z);
    }
	public void RecieveText(TextAsset t, int zone)
    {
        textFile = t;
		zoneNum = zone;
    }
    public void NoSignal()
    {
		textBox.SetActive(false);
        textFile = null;
    }
}
