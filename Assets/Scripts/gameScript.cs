using UnityEngine;
using System.Collections;

public class gameScript : MonoBehaviour {
	string state = "waiting";


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startGame(){
		state = "started";
		Debug.Log ("Game Started");

	}
}
