using UnityEngine;
using System.Collections;

public class gameScript : MonoBehaviour {
	string state = "waiting";
	HitsText hitsText;


	void Start () {
		hitsText = (HitsText)GameObject.Find ("HitsText").GetComponent (typeof(HitsText));

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startGame(){
		state = "started";

	}
}
