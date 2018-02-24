using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour {

	public GameObject spawnee;
	public static bool waveStarted = false;
	public float spawnDelay;
	public float startDelay;
	private int enemyCount = 10;
	private int initEnemyCount;
	public static bool waveReady = true;
	public bool waveReady2;

	// Use this for initialization
	void Start () {
		initEnemyCount = enemyCount;
		StartCoroutine( SpawnObject());
	}
	
	// Update is called once per frame
	void Update () {
		waveReady2 = waveReady;
	}

	IEnumerator SpawnObject () {
		while (true) {
			yield return new WaitForSeconds (startDelay);
			while (enemyCount != 0 && waveReady == true) {
				GameObject newAvacado = (GameObject)Instantiate (spawnee, transform.position, transform.rotation);
				WaveManager.CreatedAvacado (newAvacado);
				enemyCount--;
				//Debug.Log ("Avacado Created");
				waveStarted = true;

				yield return new WaitForSeconds (spawnDelay);
			}
			//initEnemyCount = WaveManager.waveCount * 1;
			initEnemyCount = WaveManager.waveCount * 1;
			if (WaveManager.AvacadoList.Count == 0 && waveStarted) {
				WaveManager.waveEnd = true;
				waveReady = false;
				Debug.Log ("Waiting For EndWave");
				enemyCount = initEnemyCount;
			}
		}
	}
}
