using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	protected CharacterController control;
	protected Vector3 force_Gravity = Vector3.zero;
	protected Vector3 force_Player = Vector3.zero;
	protected Vector3 force_Weapon = Vector3.zero;

	void Start () {
		control = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	Vector3 CalculateForces (){
		//Horizontal Player Movement
		force_Player = new Vector3(Input.GetAxis ("Horizontal"), 0f, 0f);
		//Assign Gravity to
		return force_Player;
	}
}
