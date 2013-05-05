using UnityEngine;
using System.Collections;

public class RocketAmmo : MonoBehaviour {
	
	float initposition;
	float initrotation;
	float speed = 2;
	public GameObject explosion;
	//GameObject bullet;
	
	// Use this for initialization
	void Start () {
		transform.Translate(new Vector3(0.125f, 0.017f, 0));
	}
	
	// Update is called once per frame
	void Update () {
		//float movex = Mathf.Cos(transform.eulerAngles.z * Mathf.Deg2Rad) * speed * Time.deltaTime;
		//float movey = Mathf.Sin(transform.eulerAngles.z * Mathf.Deg2Rad) * speed * Time.deltaTime;
		transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
	}
	
	void OnTriggerEnter(Collider collider) {
		Debug.Log ("HIT");
		if (collider.gameObject.tag == "Level") {
			Instantiate (explosion, transform.position, transform.rotation);
			Destroy(gameObject);
			Debug.Log ("HIT LEVEL");
		}
	}
}
