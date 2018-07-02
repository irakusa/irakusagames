using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBoxScript : MonoBehaviour {

	public GameObject cube;
	public int shoottime = 0;
	public int kurukuru = 0;


	// Update is called once per frame
	void Update () {

		if (Time.frameCount % shoottime == 0) {
		
			Vector3 position = new Vector3 (Random.Range (-5, 5), 10f, -1f);
			Quaternion kaiten = Quaternion.Euler( new Vector3 (0, 0, Random.Range (0f, kurukuru)));
			Instantiate (cube, position, kaiten);
		
		}

	}
		
}
