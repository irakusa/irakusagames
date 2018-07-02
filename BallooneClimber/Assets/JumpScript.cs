using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour {

	GameObject jump;
	PlayerScript PS;

	void Start(){

		jump = GameObject.Find ("PlayerObj");
		PS = jump.GetComponent<PlayerScript> ();

	}

	void OnTriggerEnter(Collider obj){

		if (obj.gameObject.name != "Rightwall" && obj.gameObject.name != "Leftwall") {

			PS.hop = 0;
			Debug.Log ("着地");
		
		}
	}

}
