using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	protected Vector3 move = Vector3.zero;
	
	public float moveSpeed = 3f;
	public float jumpSpeed = 5f;
	protected bool jump;
	
	protected Vector3 gravity = Vector3.zero;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("left")){
			transform.Translate (Vector3.left * 10 * Time.deltaTime);
		}
	}
}
