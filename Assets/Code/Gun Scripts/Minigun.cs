using UnityEngine;
using System.Collections;

public class Minigun : MonoBehaviour {
	public GameObject bullet;
	float cooldown = 0.0f;
	float fireRate = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//if(cooldown > 0){
        // 	cooldown -= Time.deltaTime;
		//}
		//else if (Input.GetButton("Fire1")){
		//	Fire ();
		//	cooldown = 0.1f;

		//}
	}
	
	public bool Fire (){
		Instantiate (bullet, transform.position, transform.rotation);
		return true;
	}
}