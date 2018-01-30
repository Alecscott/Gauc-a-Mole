using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	private SteamVR_TrackedController controller;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	// Use this for initialization
	void Start () {
		controller = GetComponent<SteamVR_TrackedController>();
		if (controller == null) {
			controller = gameObject.AddComponent<SteamVR_TrackedController>();
		}
		controller.TriggerClicked += new ClickedEventHandler (Fire);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Fire(object sender, ClickedEventArgs e){
		if(this.gameObject.transform.parent != null){
		Debug.Log ("Fired");
		var bullet = (GameObject)Instantiate(bulletPrefab,bulletSpawn.position,bulletSpawn.rotation);
		bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * 50;

		Destroy (bullet, 2.0f);
		}
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Enemy") {
			Destroy (gameObject);
		}
	}

}
