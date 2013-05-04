using UnityEngine;
using System.Collections;

public class PlayerAnimController : MonoBehaviour {
	
	private bool walking = false;
	private tk2dAnimatedSprite anim;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<tk2dAnimatedSprite>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Horizontal") > 0 && !anim.IsPlaying("RunRight")) {
			Debug.Log ("WALK");
			anim.Play("RunRight");
		}
		else if (Input.GetAxis ("Horizontal") < 0) {
		
		}
		
	}
}
