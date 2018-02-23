using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class Shooting2 : MonoBehaviour {
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public bool firing;
	public bool firingA;
	public bool firingB;
	public bool firingC;
	public bool firingD;
	public bool firingE;
	public PostProcessingProfile Post;
	public float Changespeed = 0.1f;
	float reset = 1500;

	// Sound
	private SoundManager soundScript;

	// Use this for initialization
	void Start () {
		firing = false;
		firingA = false;
		firingB = false;
		firingC = false;
		firingD = false;
		firingE = false;

		// Finds the 'SoundManager' object, grabs the script 'SoundManager'
		soundScript = (SoundManager) GameObject.Find("SoundManager").GetComponent(typeof(SoundManager));
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("LHandTrigger") == 1 && this.gameObject.transform.parent.tag == "Left"){
			Fire ();
		}
		if(Input.GetAxis("LHandTrigger") == 0){
			firing = true;
		}

		if(Input.GetKeyDown(KeyCode.Joystick1Button2) && this.gameObject.transform.parent.tag == "Left"){
			FireA ();
		}
		if(Input.GetKeyUp(KeyCode.Joystick1Button2)){
			firingA = true;
		}

		if(Input.GetKeyDown(KeyCode.Joystick1Button3) && this.gameObject.transform.parent.tag == "Left"){
			FireB ();
		}
		if(Input.GetKeyUp(KeyCode.Joystick1Button3)){
			firingB = true;
		}
			
		if(Input.GetAxis("LeftMainTrigger") == 1 && this.gameObject.transform.parent.tag == "Left"){
			FireD ();
		}
		if(Input.GetAxis("LeftMainTrigger") == 0){
			firingD = true;
		}

		if(Input.GetAxis("LeftJoyStickHorrizontal") >= 0.5 ){
			Debug.Log ("Left Joystick Moving Right");
		}
		if(Input.GetAxis("LeftJoyStickHorrizontal") <= -0.5){
			Debug.Log ("Left Joystick Moving Left");
		}

		if(Input.GetAxis("LeftJoyStickVertical") <= -0.5 ){
			//copy current colorgrading settings from the profile into a temporary variable
			ColorGradingModel.Settings TintChange = Post.colorGrading.settings;

			//change the intensity in the temporary settings variable
			TintChange.basic.tint += Changespeed;


			//set the hue shift settings in the actual profile to the temp settings with the changed value

			if (TintChange.basic.tint >= 500) {
				TintChange.basic.tint -= reset;
			} 
			Post.colorGrading.settings = TintChange;

		}
		if(Input.GetAxis("LeftJoyStickVertical") >= 0.5){
			//copy current colorgrading settings from the profile into a temporary variable
			ColorGradingModel.Settings TintChange = Post.colorGrading.settings;

			//change the intensity in the temporary settings variable
			TintChange.basic.tint -= Changespeed;
			if (TintChange.basic.tint <= -1000) {
				TintChange.basic.tint += reset;
			} 

				//set the hue shift settings in the actual profile to the temp settings with the changed value
			Post.colorGrading.settings = TintChange;

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
	void FireA()
	{
		if(firingA == true) {
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
			firingA = false;

		}
	}
	void FireB()
	{
		if(firingB == true) {
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
			firingB = false;

		}
	}
	void FireC()
	{
		if(firingC == true) {
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
			firingC = false;

		}
	}
	void FireD()
	{
		if(firingD == true) {
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
			firingD = false;

		}
	}
	void FireE()
	{
		if(firingE == true) {
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
			firingE = false;

		}
	}
}
