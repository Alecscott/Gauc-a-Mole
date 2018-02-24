using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvacadoTreeManager : MonoBehaviour {

	private Vector3 spawnLocation;
	private float x;
	private float z;
	public static List<GameObject> AvacadoTreeList = new List<GameObject>();
	public GameObject treePrefab;
	public GameObject player;
	private Vector3 playerPos;
	public Transform target;

	// Use this for initialization
	void Start () {
		playerPos = player.transform.position;
		target = player.transform;
	}
	
	// Update is called once per frame
	void Update () {
		x = Random.Range (-10, 10);
		z = Random.Range (-10, 10);
		while ((x > -7 && x < 7) || (z > -7 && z < 7)) {
			x = Random.Range (-10, 10);
			z = Random.Range (-10, 10);
		}
		spawnLocation = new Vector3 (x, 7, z);
	}

	public void spawnTree () {
		GameObject newAvacadoTree = (GameObject)Instantiate (treePrefab, spawnLocation, Quaternion.identity);
		RaycastHit hit;
		if (Physics.Raycast (newAvacadoTree.transform.position, Vector3.down, out hit)) {
			Vector3 newPos = hit.point;
			newAvacadoTree.transform.position = newPos;
		}
		newAvacadoTree.transform.LookAt (target);
		CreatedAvacadoTree (newAvacadoTree);
	}
	public static void CreatedAvacadoTree (GameObject avacadoTree) {
		//Debug.Log ("Avacado Tree Added");
		AvacadoTreeList.Add (avacadoTree);
	}
	public static void DestroyedAvacadoTree (GameObject avacadoTree) {
		//Debug.Log ("Avacado Tree Removed");
		AvacadoTreeList.Remove (avacadoTree);
	}
}
