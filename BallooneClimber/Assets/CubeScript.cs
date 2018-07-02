using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

	public float rakka = 0;
	public float kaiten = 0;
	public float starttime = 0;
	float time = 0;
	float speed = 0;
	float spin = 0;

	void Start (){
		
		speed = Random.Range (-1.0f, -5.0f);
		spin = Random.Range (1.0f, 10.0f);

	}

	void Update () {

		time += Time.deltaTime;

		if (time > starttime) {
			
			transform.Translate (0, rakka * speed, 0, Space.World);
			transform.Rotate (0, 0, kaiten * spin);

		}
	}
}
