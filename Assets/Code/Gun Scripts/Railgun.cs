using UnityEngine;
using System.Collections;

public class Railgun : MonoBehaviour {
	public GameObject bullet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1")){
			Fire ();
		}
	}
	
	void Fire (){
		Instantiate (bullet, transform.position, transform.rotation);
	}
}
