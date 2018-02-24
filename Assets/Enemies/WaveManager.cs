using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour {

	public static List<GameObject> AvacadoList = new List<GameObject>();
	public static int waveCount = 1;
	public static bool waveEnd = false;
	public float waveDelay;
	public AvacadoTreeManager am;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine( EndWave());
	}

	IEnumerator EndWave(){
		if (waveEnd == true) {
			Debug.Log ("Ending Wave");
			waveCount += 1;
			waveEnd = false;

			am.spawnTree ();
			TimedSpawn.waveStarted = false;
			TimedSpawn.waveReady = true;
			yield return new WaitForSeconds (waveDelay);

			startNextWave ();
		}
	}

	private void startNextWave()
	{

	}

	public static void CreatedAvacado (GameObject avacado) {
		//Debug.Log ("Avacado Added");
		AvacadoList.Add (avacado);
	}
	public static void DestroyedAvacado (GameObject avacado) {
		//Debug.Log ("Avacado Removed");
		AvacadoList.Remove (avacado);
	}
}