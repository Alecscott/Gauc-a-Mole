using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SteamVR_TrackedObject))]
public class Weapon : MonoBehaviour {

	public SteamVR_TrackedObject trackedObj;

	public Transform HandPos;

	Weapon nextWeapon;


	public void Equip()
	{
		HandPos = GameObject.FindGameObjectWithTag ("RightHand").transform;
		trackedObj = GetComponent<SteamVR_TrackedObject>();
		trackedObj.index = SteamVR_TrackedObject.EIndex.Device2;
		trackedObj.origin = HandPos;
		transform.SetPositionAndRotation (HandPos.position, Quaternion.identity);
		transform.SetParent (HandPos);
	}

	public void Disarm()
	{
		HandPos = null;
		trackedObj = null;


		Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
