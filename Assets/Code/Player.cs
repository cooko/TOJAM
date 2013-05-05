using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	protected CharacterController control;
	protected Vector3 move = Vector3.zero;
	
	public float moveSpeed;
	public float jumpSpeed;
	public bool jump;
	
	protected Vector3 gravity = Vector3.zero;

	GameObject Minigun;
	GameObject Railgun;
	GameObject RocketLauncher;
	
	// Use this for initialization
	void Start () {
		control = GetComponent<CharacterController>();
		moveSpeed = 3;
		jumpSpeed = 3;
		Minigun = GameObject.Find("Minigun");
		Railgun = GameObject.Find("Railgun");
		RocketLauncher = GameObject.Find("RocketLauncher");

		if (!control)
		{
			Debug.LogError("Unit.Start() " + name + " has no CharacterController!");
			enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}
	
	void Move(){
		move = new Vector3(Input.GetAxis ("Horizontal"), 0f, 0f);
		
		if (!control.isGrounded)
		{
			gravity += Physics.gravity * Time.deltaTime;	
		}
		else
		{
			gravity = Vector3.zero;	
			
			if (Input.GetButton("Jump"))
			{
				gravity.y = jumpSpeed;
				jump = false;
			}
		}
		
		move += gravity;
		
		control.Move (move * Time.deltaTime);
	}
	void Shoot(){
	}
	void SwitchWeapon() {
	}
}
