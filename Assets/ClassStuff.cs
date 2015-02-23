using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClassStuff : MonoBehaviour {

	public float speed = 5f;
	//this is a public variable, so that it can be called later in start/updated
	//also shows it in the inspector to be messed with

	//use public variables to get objects to communicate with each other
	public Text uiText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey (KeyCode.W)) {
			transform.position += transform.forward * Time.deltaTime * speed;
			uiText.text = "I'm moving forward!";
		}

		if ( Input.GetKey (KeyCode.S)) {
			transform.position -= transform.forward * Time.deltaTime * speed;
			uiText.text = "I'm moving backward!";
		}
	}
}
