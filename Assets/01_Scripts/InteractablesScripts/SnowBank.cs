using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class SnowBank : MonoBehaviour {
    public mono_player_movement p;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (p.running)
        {
            StartCoroutine(Notify());
            this.gameObject.transform.parent.GetChild(1).gameObject.SetActive(true);
            
        }
    }
    IEnumerator Notify()
    {
        GamePad.SetVibration(PlayerIndex.One, 1.0f, 1.0f);
        yield return new WaitForSeconds(0.5f);
        GamePad.SetVibration(PlayerIndex.One, 0.0f, .0f);
        this.gameObject.SetActive(false);
    }
}
