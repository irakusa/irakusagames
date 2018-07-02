using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverTime : MonoBehaviour {

	private Text targettext;

	// Use this for initialization
	void Start () {

		this.targettext = this.GetComponent<Text> ();
		this.targettext.text = SootBoxMasterScript.time.ToString("n2");

	}
	
	// Update is called once per frame
	void Update () {

	}
}
