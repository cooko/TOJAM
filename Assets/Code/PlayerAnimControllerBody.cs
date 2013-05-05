using UnityEngine;
using System.Collections;

public class PlayerAnimControllerBody : MonoBehaviour {
	
	public string player;
	private int facing;
	private tk2dAnimatedSprite anim;
	
	// Use this for initialization
	void Start () {
		facing = 1;
		anim = GetComponent<tk2dAnimatedSprite>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis (player + " - HorizontalLook") > 0) {
			if (facing == 0){
				anim.FlipX();
				facing = 1;
			}
		}
		else if (Input.GetAxis (player + " - HorizontalLook") < 0) {
			if (facing == 1){
				anim.FlipX ();
				facing = 0;
			}
		}
	}
}
