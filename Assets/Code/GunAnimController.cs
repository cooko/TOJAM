using UnityEngine;
using System.Collections;

public class GunAnimController : MonoBehaviour {
	
	public int facing;
	private tk2dAnimatedSprite anim;
		public float smooth = 2.0F;
    public float tiltAngle = 30.0F;
	public Quaternion initrotation;
	public Vector3 initlocalpos;
	// Use this for initialization
	void Start () {
		//facing = 1;
				initrotation = transform.rotation;
		initlocalpos = transform.localPosition;
		anim = GetComponent<tk2dAnimatedSprite>();
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 rstickinput = new Vector3(Input.GetAxis ("Right Horizontal"), Input.GetAxis ("Right Vertical"), 0);
		float angle = Mathf.Atan2(Input.GetAxis("Right Vertical"), Input.GetAxis ("Right Horizontal")) * Mathf.Rad2Deg;
		Vector3 parentposition = transform.parent.position;
    	//Vector3 rstickinput = new Vector3(Input.GetAxis ("Right Horizontal"), Input.GetAxis ("Right Vertical"), 0);

		transform.rotation = initrotation;
		transform.localPosition = initlocalpos;
		
		transform.Rotate(0, 0, angle);
		
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
