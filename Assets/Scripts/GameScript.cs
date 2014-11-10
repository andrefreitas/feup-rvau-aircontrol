using UnityEngine;
using System.Collections;

public class gameScript : MonoBehaviour
{
		string state = "waiting";
		public bool isRunwayPlaced;
		GUIScript gui;
		GameObject runway;
		CessnaScript cessna;
		GameObject cessnago;

		void Start ()
		{
				gui = (GUIScript)GameObject.Find ("GUI").GetComponent (typeof(GUIScript));
				cessna = (CessnaScript)GameObject.Find ("Cessna").GetComponent (typeof(CessnaScript));
				cessnago = GameObject.Find ("Cessna");	
				runway = GameObject.Find ("SmallAirport");
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		public void startGame ()
		{
			state = "started";
			gui.message = "Começou o jogo!";
			gui.showScore = true;
			startGame ();
		isRunwayPlaced = true;
		cessna.turnOn ();
		
	}
		public void control (string direction)
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
