using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour
{
	string state;
	GUIScript gui;
	GameObject runway;
	CessnaScript cessna;
	GameObject cessnago;
	int score;

	void Start (){
		gui = (GUIScript)GameObject.Find ("GUIScript").GetComponent (typeof(GUIScript));
		cessna = (CessnaScript)GameObject.Find ("Cessna").GetComponent (typeof(CessnaScript));
		cessnago = GameObject.Find ("Cessna");	
		runway = GameObject.Find ("Runway");
		score = 0;
		state = "waiting";
	}

	public void startGame (){
		state = "started";
		gui.startGame ();
		cessna.turnOn ();
	}

	public void control (string direction){
		Debug.Log ("Plane control: " + direction);

		if (direction == "left") {
			cessna.headLeft (70, cessnago);
		} else if (direction == "right") {
			cessna.headRight (70, cessnago);
		} else if (direction == "up") {
			cessna.up (70, cessnago);
		} else if (direction == "down") {
			cessna.down (70, cessnago);
		}
	}

	public int getScore (){
		return score;
	}
	
}