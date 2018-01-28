using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mono_camera_horizontal_follow : MonoBehaviour {

	public Transform thePlayer;

	void Update(){
		this.transform.position = new Vector3 (thePlayer.transform.position.x, 0f, -10f);

	}
}