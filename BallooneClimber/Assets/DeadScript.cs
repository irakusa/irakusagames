using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadScript : MonoBehaviour {

	void OnCollisionEnter(Collision obj){

		if (obj.gameObject.name == "PlayerObj") {
		
			SceneManager.LoadScene("GameOver");
		
		}

		Debug.Log("destroy");
		Destroy (obj.gameObject);
	}
}
