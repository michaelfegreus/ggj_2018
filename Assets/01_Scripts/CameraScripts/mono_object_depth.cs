using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mono_object_depth : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);// The all important background Z-space layer movement experiment.
	}
}
