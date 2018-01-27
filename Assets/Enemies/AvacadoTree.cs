using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvacadoTree : MonoBehaviour {
	public AvacadoManager am;

	// Use this for initialization
	void Start () {
		am = gameObject.GetComponent<AvacadoManager> ();
	}

	void SpawnAvacado (){
		am.CreateAvacado ();
	}
}
