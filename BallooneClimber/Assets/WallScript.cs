using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {

	void OnCollisionEnter(Collision obj){

		string objname = obj.gameObject.name;
		Debug.Log (objname);


		if (this.gameObject.name == "Leftwall") {
			if (obj.gameObject.layer == 8) {
				Debug.Log ("Left");
				obj.transform.Translate (11f, 0f, 0f, Space.World);
			}
		}

		if (this.gameObject.name == "Rightwall") {

			Debug.Log ("Right");
			obj.transform.Translate (-11f, 0f, 0f, Space.World);
		
		}


	}

}
