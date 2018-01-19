using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour {
	
	private Valve.VR.EVRButtonId touchPad = Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad;
	private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;

	private SteamVR_TrackedObject trackedObj;

	private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }

	private GameObject pickup;

	// Use this for initialization
	void Start () {
		trackedObj = GetComponent<SteamVR_TrackedObject>();
		Debug.Log ("Start");
	}
	
	// Update is called once per frame
	void Update () {
		if (controller == null)
		{
			Debug.Log("Controller not initialized");
			return;
		}
		Debug.Log ("pickup");
		if (controller.GetPressDown(touchPad) && pickup != null)
		{
			pickup.transform.parent = this.transform;
			pickup.GetComponent<Rigidbody>().isKinematic = true;
		}
		if (controller.GetPressUp(touchPad) && pickup != null)
		{
			pickup.transform.parent = null;
			pickup.GetComponent<Rigidbody>().isKinematic = false;
		}
	}

	private void OnTriggerEnter(Collider collider)
	{
		Debug.Log ("OnTriggerEnter");
		pickup = collider.gameObject;

}
	private void OnTriggerExit(Collider collider)
	{
		Debug.Log ("OnTriggerExit");
		pickup.transform.parent = null;
		pickup.GetComponent<Rigidbody>().useGravity = true;
		pickup = null;
	}
}
