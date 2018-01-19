using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour {
	public Transform target;
	public Transform myTransform;

	public GameObject player;

	void Update () {

		transform.LookAt(target);

		transform.Translate (Vector3.forward * 3 * Time.deltaTime);
			
				//Here Call any function U want Like Shoot at here or something
			


	}
}
