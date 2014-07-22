using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public float movementSpeed = 10;
	public Vector3 direction = Vector3.left;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(direction * movementSpeed * Time.deltaTime);
	}
}
