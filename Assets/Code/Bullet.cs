using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	float initposition;
	float initrotation;
	float speed = 3;
	//GameObject bullet;
	
	// Use this for initialization
	void Start () {
		//bullet = GetComponent<GameObject>();
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
			Destroy(gameObject);
			Debug.Log ("HIT LEVEL");
		}
	}
}
