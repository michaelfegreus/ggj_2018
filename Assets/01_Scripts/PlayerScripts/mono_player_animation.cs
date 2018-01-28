using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mono_player_animation : MonoBehaviour {

	Animator anim;

	float inputX;
	float inputY;

	bool playerMoving;
	Vector2 lastMove;

	float movementThreshold = .1f;

	void Start(){
		anim = GetComponent<Animator> ();
	}

	void Update(){
		inputX = Input.GetAxis ("Horizontal"); // A/D, LeftArrow/RightArrow
		inputY = Input.GetAxis ("Vertical"); // W/S, UpArrow/DownArrow

		playerMoving = false; // Change this if there is input happening.
		if (inputX > movementThreshold || inputY > movementThreshold || inputX < movementThreshold * -1f  || inputY < movementThreshold * -1f ) {
			playerMoving = true;
		}
		if(inputX > movementThreshold || inputX < movementThreshold * -1f ){
			lastMove = new Vector2 (inputX, 0f);
		}
		if(inputY > movementThreshold || inputY < movementThreshold * -1f ){
			lastMove = new Vector2 (0f, inputY);
		}

		anim.SetFloat ("MoveX", inputX);
		anim.SetFloat ("MoveY", inputY);
		anim.SetBool ("PlayerMoving", playerMoving);
		anim.SetFloat ("LastMoveX", lastMove.x);
		anim.SetFloat ("LastMoveY", lastMove.y);
	}

}