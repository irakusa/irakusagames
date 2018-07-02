using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour {

	void OnTriggerExit(Collider obj){

		if (obj.gameObject.name == "PlayerObj") {
		
			Debug.Log (obj.transform.position);
			obj.transform.position = new Vector3(0f, 2f, -1f);
		
		}

	}

}
