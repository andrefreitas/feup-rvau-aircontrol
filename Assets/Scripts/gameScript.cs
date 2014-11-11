using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour{
	GUIScript gui;
	CessnaScript cessna;
	int score;

	void Start (){
		gui = (GUIScript)GameObject.Find ("GUIScript").GetComponent (typeof(GUIScript));
		cessna = (CessnaScript)GameObject.Find ("Cessna").GetComponent (typeof(CessnaScript));	
		score = 0;
	}

	public void startGame (){
		gui.startGame ();
		cessna.turnOn ();
	}

	public void control (string direction){
		Debug.Log ("Plane control: " + direction);

		if (direction == "left") {
			cessna.headLeft (70);
		} else if (direction == "right") {
			cessna.headRight (70);
		} else if (direction == "up") {
			cessna.up (70);
		} else if (direction == "down") {
			cessna.down (70);
		}
	}

	public void increaseSpeed(int amount){
		cessna.increaseSpeed (amount);
	}

	public int getScore (){
		return score;
	}
	
}