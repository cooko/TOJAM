using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	protected CharacterController control;
	protected Vector3 move = Vector3.zero;
	protected Vector3 walk = Vector3.zero;
	
	public float moveSpeed;
	public float jumpSpeed;
	public bool jump;
	
	float friction;
	Vector3 momentum = Vector3.zero;
	
	protected Vector3 gravity = Vector3.zero;

	GameObject Minigun;
	GameObject Railgun;
	GameObject RocketLauncher;
	GameObject Gun;
	Weapon Equipped;

	
	// Use this for initialization
	void Start () {
		control = GetComponent<CharacterController>();
		moveSpeed = 3;
		jumpSpeed = 3;
		friction = 15;
		Minigun = GameObject.Find("Minigun");
		Railgun = GameObject.Find("Railgun");
		RocketLauncher = GameObject.Find("RocketLauncher");
		Equipped = Minigun.GetComponent<Weapon>();
		Gun = Minigun;
		Railgun.SetActive(false);
		RocketLauncher.SetActive(false);

		
		if (!control)
		{
			Debug.LogError("Unit.Start() " + name + " has no CharacterController!");
			enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		//SwitchWeapon();
		Fire();
		Move();

	}
	
	void Move(){
		move = Vector3.zero;
		walk = new Vector3(Input.GetAxis ("Horizontal"), 0, 0);
		if(!control.isGrounded){
			gravity.y += -10 * Time.deltaTime;
		}else{
			gravity.y = 0;
			momentum.y = 0;
			//decrease x momentum towards 0
			if (momentum.x > 0){
				if (momentum.x - friction < 0){
					momentum.x = 0;
				}
				else{
					momentum.x -= friction;				}
			}
			else if (momentum.x < 0){
				if (momentum.x + friction > 0){
					momentum.x = 0;
				}
				else{
					momentum.x += friction;
				}
			}
			if (Input.GetButton("Jump"))
			{
				gravity.y = jumpSpeed;
			}
		}
		move += walk;
		move += gravity;
		move += momentum * Time.deltaTime;
		control.Move (move * Time.deltaTime);

	}
	
	/*void Move(){
		walk = new Vector3(Input.GetAxis ("Horizontal"), 0, 0);
		move = new Vector3(Input.GetAxis ("Horizontal"), 0f, 0f);
		
		
		if (!control.isGrounded)
		{
			gravity += Physics.gravity * Time.deltaTime;
		}
		else
		{
			gravity = Vector3.zero;	
			
			if (Input.GetButton("Jump"))
			{
				gravity.y = jumpSpeed;
				jump = false;
			}
		}
		
		move += gravity;
		
		control.Move (move * Time.deltaTime);
	}
	void Shoot(){
	}
	void SwitchWeapon() {
		if(Input.GetKeyDown("space")){
			if(Minigun.activeSelf){
				Minigun.SetActive(false);
				RocketLauncher.SetActive(true);
				RocketLauncher.renderer.enabled = true;
				Gun = RocketLauncher;
				Equipped = Minigun.GetComponent<Weapon>();
			}else if(RocketLauncher.activeSelf){
				RocketLauncher.SetActive(false);
				Railgun.SetActive(true);
				Railgun.renderer.enabled = true;
				Gun = Railgun;
				Equipped = RocketLauncher.GetComponent<Weapon>();

			}else if(Railgun.activeSelf){
				Railgun.SetActive(false);
				Minigun.SetActive(true);
				Minigun.renderer.enabled = true;
				Gun = Minigun;
				Equipped = Railgun.GetComponent<Weapon>();

			}
		}
	}*/
	
	void OnTriggerEnter(Collider other) {
		if(other.tag == "Pickup_Rocket"){
			Minigun.SetActive(false);
			Railgun.SetActive(false);
			RocketLauncher.SetActive(true);
			RocketLauncher.renderer.enabled = true;
			Equipped = RocketLauncher.GetComponent<Weapon>();
			Gun = RocketLauncher;
        	//Destroy(other.gameObject);
		}else if(other.tag == "Pickup_Railgun"){
			Minigun.SetActive(false);
			RocketLauncher.SetActive(false);
			Railgun.SetActive(true);
			Railgun.renderer.enabled = true;
			Equipped = Railgun.GetComponent<Weapon>();
			Gun = Railgun;
        	//Destroy(other.gameObject);
		}
    }
	void Fire(){
		if (Input.GetButton("Fire1")){
			if (Equipped.Fire()){
				Debug.Log (Gun.transform.eulerAngles);
				momentum.x -= Mathf.Cos (Gun.transform.eulerAngles.z * Mathf.Deg2Rad) * Equipped.knockback;
				momentum.y -= Mathf.Sin (Gun.transform.eulerAngles.z * Mathf.Deg2Rad) * Equipped.knockback;
			}
		}
	}
	
}
