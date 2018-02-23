using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Bullet") {

			BulletChanges bulletchanges = col.GetComponent<BulletChanges> ();
			bulletchanges.HitSomething = true;
		}
	}
}
