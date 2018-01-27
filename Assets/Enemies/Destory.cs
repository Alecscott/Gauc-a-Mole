using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour {


	
	// Update is called once per frame
	void OntriggerEnter (Collider col) {
		if (col.gameObject.tag == "Enemy") {
			Destroy (col.gameObject);
		}
	}
}
