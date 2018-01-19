using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Enemy") {
			Destroy (col.gameObject);
		}
	}
}
