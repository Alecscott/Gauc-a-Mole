using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletChanges : MonoBehaviour {
	public GameObject LeftOver;
	public GameObject DecayEffect;
	public Transform Rotation;
	public bool HitSomething;
	// Use this for initialization
	void Start () {
		HitSomething = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (HitSomething == true) {
			var Hit = (GameObject)Instantiate (
				LeftOver,
				gameObject.transform.position,
				Random.rotation);
			Destroy (Hit, 2.0f);
			Destroy (gameObject);


		}


	}

	void OnDestroy() {
		if (HitSomething == false) {
			var Decay = (GameObject)Instantiate (
				            DecayEffect,
				            gameObject.transform.position,
							Random.rotation);
			Destroy (Decay, 2.0f);
		} 

		}

}
