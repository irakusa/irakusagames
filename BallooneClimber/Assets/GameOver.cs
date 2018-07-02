using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {

		transform.Rotate (new Vector3 (Random.Range (0, 45), Random.Range (0, 45), Random.Range (0, 45)));
		GetComponent<Rigidbody> ().AddForce (Vector3.down * 40f, ForceMode.Impulse);

		Debug.Log (SootBoxMasterScript.time);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
