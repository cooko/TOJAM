using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	protected CharacterController control;
	protected Vector3 move = Vector3.zero;
	
	public float moveSpeed = 3f;
	public float jumpSpeed = 5f;
	protected bool jump;
	
	protected Vector3 gravity = Vector3.zero;


	// Use this for initialization
	void Start () {
		control = GetComponent<CharacterController>();
		
		if (!control)
		{
			Debug.LogError("Unit.Start() " + name + " has no CharacterController!");
			enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		move = new Vector3(Input.GetAxis ("Horizontal"), 0f, 0f);
		
		//move.Normalize();
		
		//move = transform.TransformDirection (move);
		
		if (Input.GetKey(KeyCode.Space) && control.isGrounded)
		{
			jump = true;	
		}
		
		if (!control.isGrounded)
		{
			gravity += Physics.gravity * Time.deltaTime;	
		}
		else
		{
			gravity = Vector3.zero;	
			
			if (jump)
			{
				gravity.y = jumpSpeed;
				jump = false;
			}
		}
		
		move += gravity;
		
		control.Move (move * Time.deltaTime);	}
}
