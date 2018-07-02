using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour {

	private Text retry;
	private float time;
	// Use this for initialization
	void Start () {

		this.retry = this.GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;

		if (time > 5) {
		
			this.retry = this.GetComponent<Text> ();
			this.retry.text = "Space キー: リトライ";

			if (Input.GetButtonDown ("Jump")) {

				SceneManager.LoadScene ("Main");

			}

		}

	}
}
