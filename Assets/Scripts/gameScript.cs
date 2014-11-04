using UnityEngine;
using System.Collections;

public class gameScript : MonoBehaviour {
	string state = "waiting";

	// Targets
	public bool isAirportPlaced = false;
	public bool isHeliportPlaced = false;
	public bool isSmallAirportPlaced = false;

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

	public bool allRunwaysPlaced(){
		return isAirportPlaced && isHeliportPlaced && isSmallAirportPlaced;
	}
}
