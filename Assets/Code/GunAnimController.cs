using UnityEngine;
using System.Collections;

public class GunAnimController : MonoBehaviour {
	
	public int facing;
	private tk2dAnimatedSprite anim;
	// Use this for initialization
	void Start () {
		//facing = 1;
		anim = GetComponent<tk2dAnimatedSprite>();
	}
	
	// Update is called once per frame
	void Update () {
    	Vector3 rstickinput = new Vector3(Input.GetAxis ("Right Horizontal"), Input.GetAxis ("Right Vertical"), 0);
		if (Input.GetAxis ("Right Horizontal") > 0){
			if (facing == 0){
				anim.FlipY();
				facing = 1;
			}
		}
		else if (Input.GetAxis ("Right Horizontal") < 0)
		{
			if (facing == 1){
				anim.FlipY();
				facing = 0;
			}
		}

	}
}
