using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour {

	public GameObject spawnee;
	public bool stopSpawning = false;
	public float spawnDelay;
	public float startDelay;
	public float waveDelay;
	public int enemyCount;
	private int initEnemyCount;
	public AvacadoManager am;

	// Use this for initialization
	void Start () {
		initEnemyCount = enemyCount;
		StartCoroutine( SpawnObject());
	}
	
	// Update is called once per frame
	IEnumerator SpawnObject () {
		yield return new WaitForSeconds (startDelay);
		while (enemyCount > 0) {
			enemyCount--;
			Instantiate (spawnee, transform.position, transform.rotation);
			//am.CreateAvacado();
			yield return new WaitForSeconds (spawnDelay);
		}
		enemyCount = initEnemyCount;
		yield return new WaitForSeconds (waveDelay);
	}
}
