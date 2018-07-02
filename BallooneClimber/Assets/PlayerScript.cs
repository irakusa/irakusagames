using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float playerspeed = 0;
	public int hop = 0;

	// Update is called once per frame
	void Update () {
		
		float x = Input.GetAxis ("Horizontal");

		transform.Translate(x * playerspeed, 0, 0, Space.World);
		transform.Rotate(new Vector3(0, x * -45f, 0));

		if (transform.eulerAngles.y > 180 && transform.eulerAngles.y < 270) {
		
			//Debug.Log ("rotate180");
			transform.rotation = Quaternion.Euler (0, 180, 0);
		
		}

		if (transform.eulerAngles.y > 271 && transform.eulerAngles.y < 360) {

			//Debug.Log ("rotate0");
			transform.rotation = Quaternion.Euler (0, 0, 0);

		}

		if (Input.GetButtonDown ("Jump")) {

			hop++;
			Debug.Log (hop);

			if (hop == 1) {

				GetComponent<Rigidbody> ().AddForce (Vector3.up * 1.5f, ForceMode.Impulse);

			}

			if (hop == 2) {

				GetComponent<Rigidbody> ().AddForce (Vector3.up * 0.8f, ForceMode.Impulse);

			}
		}

		//transform.position = Vector3.Lerp (pos, new Vector3 (pos.x, pos.y + 2f, pos.z), Time.deltaTime);
	}
		
}
