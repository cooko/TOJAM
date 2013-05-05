using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
    
	public float smooth = 2.0F;
    public float tiltAngle = 30.0F;
	public Quaternion initrotation;
	public Vector3 initlocalpos;
	public GameObject bullet;
	
	// Use this for initialization
	void Start () {
		initrotation = transform.rotation;
		initlocalpos = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update() {
        Vector3 rstickinput = new Vector3(Input.GetAxis ("Right Horizontal"), Input.GetAxis ("Right Vertical"), 0);
		float angle = Mathf.Atan2(Input.GetAxis("Right Vertical"), Input.GetAxis ("Right Horizontal")) * Mathf.Rad2Deg;
		Vector3 parentposition = transform.parent.position;

		transform.rotation = initrotation;
		transform.localPosition = initlocalpos;
		
		transform.Rotate(0, 0, angle);
		Debug.Log(Mathf.Sin(transform.eulerAngles.z * Mathf.Deg2Rad));
		if (Input.GetButton("Fire1")){
			Instantiate (bullet, transform.position, transform.rotation);
		}
    }
}
