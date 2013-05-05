using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	
	float lifeTime;
	// Use this for initialization
	void Start () {
		lifeTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		lifeTime++;
		if (lifeTime > 30){
			Destroy (gameObject);
		}
	}
}
