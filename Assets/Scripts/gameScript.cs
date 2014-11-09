using UnityEngine;
using System.Collections;

public class gameScript : MonoBehaviour
{
		string state = "waiting";

		// Targets
		public bool isAirportPlaced = false;
		public bool isHeliportPlaced = false;
		public bool isSmallAirportPlaced = false;

		// GUI
		GUIScript gui;

		// Markers
		GameObject smallAirport;

		// Airplanes
		CessnaScript cessna;
		GameObject cessnago;

		void Start ()
		{
				gui = (GUIScript)GameObject.Find ("GUI").GetComponent (typeof(GUIScript));

				cessna = (CessnaScript)GameObject.Find ("Cessna").GetComponent (typeof(CessnaScript));
				cessnago = GameObject.Find ("Cessna");	

				smallAirport = GameObject.Find ("SmallAirport");
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		public void startGame ()
		{
				state = "started";

	

		}

		public bool allRunwaysPlaced ()
		{
				return (isAirportPlaced || isHeliportPlaced || isSmallAirportPlaced);
		}

		public void heliportIsPlaced ()
		{
				isHeliportPlaced = true;
				Debug.Log ("Heliport is placed");
				checkIfCanStartGame ();
		}

		public void airportIsPlaced ()
		{
				isAirportPlaced = true;
				Debug.Log ("Airport is placed");
				checkIfCanStartGame ();
		}

		public void smallAirportPlaced ()
		{
				isSmallAirportPlaced = true;
				Debug.Log ("Small Airport is placed");
				cessna.turnOn ();
				checkIfCanStartGame ();
		}

		public void checkIfCanStartGame ()
		{
				if (allRunwaysPlaced () && state == "waiting") {
						Debug.Log ("Can start");
						gui.message = "Começou o jogo!";
						gui.showScore = true;
						startGame ();
				} else {
						Debug.Log ("Cannot start");
				}
		}
	
		public void controlPlane (string direction)
		{
				Debug.Log ("Plane control: " + direction);

				if (direction == "left") {
					cessna.headLeft(70, cessnago);
				} else if (direction == "right") {
					cessna.headRight (70, cessnago);
				} else if (direction == "up") {
					cessna.up (70, cessnago);
				} else if (direction == "down") {
					cessna.down (70, cessnago);
				}
		}


}
