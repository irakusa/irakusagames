using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SootBoxMasterScript : MonoBehaviour {

	public static float time = 0;
	GameObject start;

	// Use this for initialization
	void Start () {

		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		time += Time.deltaTime;

	}

	public GUIStyle style;

	void OnGUI(){

		GUI.Label (new Rect (10, 10, 100, 30), time.ToString(), style);

	}
}
