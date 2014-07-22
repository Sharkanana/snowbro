using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] gameObjects;
	public float spawnMin = 1f;
	public float spawnMax = 2f;

	void Start(){
		Spawn ();
	}

	void Spawn(){		
		Instantiate (gameObjects [Random.Range (0, gameObjects.Length)], transform.position, Quaternion.identity);
		Invoke("Spawn", Random.Range(spawnMin, spawnMax));
	}
}
