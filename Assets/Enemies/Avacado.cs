using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avacado : MonoBehaviour {
	static public int speed;
	static public int scale;
	private Rigidbody rb;
	public Vector3 position;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>().GetComponent <Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		position = rb.position;
	}
}
