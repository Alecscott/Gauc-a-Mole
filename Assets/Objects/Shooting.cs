using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class Shooting : MonoBehaviour {
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public bool firing;
	public bool firing1;
	public bool firing2;
	public bool firing3;
	public bool firing4;
	public bool firing5;
	public PostProcessingProfile Post;
	public float Changespeed = 0.4f;
	// Use this for initialization

	// Sound
	private SoundManager soundScript;

	void Start () {
		firing = false;
		firing1 = false;
		firing2 = false;
		firing3 = false;
		firing4 = false;
		firing5 = false;

		// Finds the 'SoundManager' object, grabs the script 'SoundManager'
		soundScript = (SoundManager) GameObject.Find("SoundManager").GetComponent(typeof(SoundManager));
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("RHandTrigger") == 1 && this.gameObject.transform.parent.tag == "Right"){
			Fire ();
		}
		if(Input.GetAxis("RHandTrigger") == 0){
			firing = true;
		}	
		if (Input.GetKeyDown(KeyCode.Joystick2Button0) && this.gameObject.transform.parent.tag == "Right"){
			Fire1 ();
		}
		if (Input.GetKeyDown(KeyCode.Joystick2Button0)){
			firing1 = true;
		}
		if (Input.GetKeyDown(KeyCode.Joystick2Button1) && this.gameObject.transform.parent.tag == "Right"){
			Fire2 ();
		}
		if (Input.GetKeyDown(KeyCode.Joystick2Button1)){
			firing2 = true;
		}

		if(Input.GetAxis("RightMainTrigger") == 1 && this.gameObject.transform.parent.tag == "Right"){
			Fire3 ();
		}
		if(Input.GetAxis("RightMainTrigger") == 0){
			firing3 = true;
		}

		if(Input.GetAxis("RightJoyStickHorrizontal") >= 0.5 ){
			Debug.Log ("Right Joystick Moving Right");
		}
		if(Input.GetAxis("RightJoyStickHorrizontal") <= -0.5){
			Debug.Log ("Right Joystick Moving Left");
		}

		if(Input.GetAxis("RightJoyStickVertical") <= -0.5 ){
			//copy current colorgrading settings from the profile into a temporary variable
			ColorGradingModel.Settings HueShift = Post.colorGrading.settings;

			//change the intensity in the temporary settings variable
			HueShift.basic.hueShift += Changespeed;

			//set the hue shift settings in the actual profile to the temp settings with the changed value
			Post.colorGrading.settings = HueShift;
		}
		if(Input.GetAxis("RightJoyStickVertical") >= 0.5){
			//copy current colorgrading settings from the profile into a temporary variable
			ColorGradingModel.Settings HueShift = Post.colorGrading.settings;

			//change the intensity in the temporary settings variable
			HueShift.basic.hueShift -= Changespeed;

			//set the hue shift settings in the actual profile to the temp settings with the changed value
			Post.colorGrading.settings = HueShift;
		}

	}
	void Fire()
	{
		if(firing == true) {
			// Create the Bullet from the Bullet Prefab
			var bullet = (GameObject)Instantiate (
				            bulletPrefab,
							bulletSpawn.position,
				            bulletSpawn.rotation);

			// Add velocity to the bullet
			bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * 50;

			soundScript.PlayAudioClip ("Smash5");

			// Destroy the bullet after 2 seconds
			Destroy (bullet, 2.0f);
			firing = false;



		}
	}
	void Fire1()
	{
		if(firing1 == true) {
			// Create the Bullet from the Bullet Prefab
			var bullet = (GameObject)Instantiate (
				bulletPrefab,
				bulletSpawn.position,
				bulletSpawn.rotation);

			// Add velocity to the bullet
			bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * 50;

			soundScript.PlayAudioClip ("Smash5");

			// Destroy the bullet after 2 seconds
			Destroy (bullet, 2.0f);
			firing1 = false;

		}
	}
	void Fire2()
	{
		if(firing2 == true) {
			// Create the Bullet from the Bullet Prefab
			var bullet = (GameObject)Instantiate (
				bulletPrefab,
				bulletSpawn.position,
				bulletSpawn.rotation);

			// Add velocity to the bullet
			bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * 50;

			soundScript.PlayAudioClip ("Smash5");

			// Destroy the bullet after 2 seconds
			Destroy (bullet, 2.0f);
			firing2 = false;

		}
	}
	void Fire3()
	{
		if(firing3 == true) {
			// Create the Bullet from the Bullet Prefab
			var bullet = (GameObject)Instantiate (
				bulletPrefab,
				bulletSpawn.position,
				bulletSpawn.rotation);

			// Add velocity to the bullet
			bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * 50;

			soundScript.PlayAudioClip ("Smash5");

			// Destroy the bullet after 2 seconds
			Destroy (bullet, 2.0f);
			firing3 = false;

		}
	}
	void Fire4()
	{
		if(firing4 == true) {
			// Create the Bullet from the Bullet Prefab
			var bullet = (GameObject)Instantiate (
				bulletPrefab,
				bulletSpawn.position,
				bulletSpawn.rotation);

			// Add velocity to the bullet
			bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * 50;

			soundScript.PlayAudioClip ("Smash5");

			// Destroy the bullet after 2 seconds
			Destroy (bullet, 2.0f);
			firing4 = false;

		}
	}
	void Fire5()
	{
		if(firing5 == true) {
			// Create the Bullet from the Bullet Prefab
			var bullet = (GameObject)Instantiate (
				bulletPrefab,
				bulletSpawn.position,
				bulletSpawn.rotation);

			// Add velocity to the bullet
			bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * 50;

			soundScript.PlayAudioClip ("Smash5");

			// Destroy the bullet after 2 seconds
			Destroy (bullet, 2.0f);
			firing5 = false;

		}
	}



}
