using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour {
	public Transform target;
	public Transform myTransform;
	private Rigidbody rb;
	public GameObject player;
	private Vector3 playerPos;

	void Start(){
		player = GameObject.FindWithTag("Player");
	}

	void Update () {
		playerPos = player.transform.position;
		target = player.transform;


		transform.LookAt(target);

		transform.Translate (Vector3.forward * 3 * Time.deltaTime);
			
				//Here Call any function U want Like Shoot at here or something

	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "InteractionObject") {
			Destroy (gameObject);
		}
	}

}
