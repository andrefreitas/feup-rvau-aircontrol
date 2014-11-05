using UnityEngine;
using System.Collections;

public class gameScript : MonoBehaviour {
	string state = "waiting";

	// Targets
	public bool isAirportPlaced = false;
	public bool isHeliportPlaced = false;
	public bool isSmallAirportPlaced = false;

	// GUI
	GUIScript gui;


	void Start () {
		gui = (GUIScript)GameObject.Find ("GUI").GetComponent (typeof(GUIScript));


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startGame(){
		state = "started";

	}

	public bool allRunwaysPlaced(){
		return (isAirportPlaced && isHeliportPlaced && isSmallAirportPlaced);
	}

	public void heliportIsPlaced(){
		isHeliportPlaced = true;
		Debug.Log ("Heliport is placed");
		checkIfCanStartGame ();
	}

	public void airportIsPlaced(){
		isAirportPlaced = true;
		Debug.Log ("Airport is placed");
		checkIfCanStartGame ();
	}

	public void smallAirportPlaced(){
		isSmallAirportPlaced = true;
		Debug.Log ("Small Airport is placed");
		checkIfCanStartGame ();
	}

	public void checkIfCanStartGame(){
		if (allRunwaysPlaced ()) {
			Debug.Log ("Can start");
			gui.message = "Começou o jogo!";
			gui.showScore = true;
		} else {
			Debug.Log("Cannot start");
		}
	}
}
