using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
	public GameObject Ammo;
	public float FireRate;
	public float knockback;
	float cooldown;
	bool fireable;
	
	// Use this for initialization
	void Start () {
		fireable = true;
		cooldown = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(cooldown > 0){
			cooldown -= 1 * Time.deltaTime;
		}else{
			fireable = true;
		}
	}
	public bool Fire(){
		if(fireable){
			Instantiate (Ammo, transform.position, transform.rotation);
			fireable = false;
			cooldown = FireRate;
			return true;
		}else{
			return false;
		}
	}
}
