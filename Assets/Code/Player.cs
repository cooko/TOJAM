using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	float y_speed;
	float x_speed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		y_speed -= 1;
		MoveMe ();
	}
	
	void MoveMe () {
		float horiz_movement = Input.GetAxis("Horizontal") * 4 * Time.deltaTime;
		float vert_movement = Input.GetAxis("Vertical") * 4 * Time.deltaTime;
		Debug.Log(Time.deltaTime);
		float vert_movement = y_speed * Time.deltaTime;
		transform.Translate (new Vector3(horiz_movement,vert_movement,0));
	}
	
	void OnTriggerEnter(Collider other){
		Debug.Log("PLAYER");
		y_speed = 0;
	}
}
