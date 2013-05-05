using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	float initposition;
	float initrotation;
	float speed = 3;
	
	// Use this for initialization
	void Start () {
		//Debug.Log ("StartMe");
	}
	
	// Update is called once per frame
	void Update () {
		float movex = Mathf.Cos(transform.eulerAngles.z * Mathf.Deg2Rad) * speed * Time.deltaTime;
		float movey = Mathf.Sin(transform.eulerAngles.z * Mathf.Deg2Rad) * speed * Time.deltaTime;
		transform.Translate(new Vector3(movex, movey, 0), Space.World);
	}
}
