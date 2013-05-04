using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MoveMe ();
	}
	
	void MoveMe () {
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
            // We are grounded, so recalculate
            // move direction directly from axes
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0,
                                    Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            
            if (Input.GetButton ("Jump")) {
                moveDirection.y = jumpSpeed;
            }
        }
        // Apply gravity
        moveDirection.y -= gravity * Time.deltaTime;
        
        // Move the controller
        controller.Move(moveDirection * Time.deltaTime);
	}
	
	/*void OnTriggerEnter(Collider other){
		Debug.Log("PLAYER | Enter");
		collided = true;
	}
	void OnTriggerExit(Collider other){
		Debug.Log("PLAYER | Exit");
		collided = false;
	}*/

}
