using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour{
	GUIScript gui;
	CessnaScript cessna;
	BusScript bus;
	int score;
	string state;
	public AudioClip beep;

	void Start (){
		gui = (GUIScript)GameObject.Find ("GUIScript").GetComponent (typeof(GUIScript));
		cessna = (CessnaScript)GameObject.Find ("Cessna").GetComponent (typeof(CessnaScript));	
		bus = (BusScript) GameObject.Find ("Bus").GetComponent (typeof(BusScript));	

		score = 0;
		state = "putRunway";
	}

	public void control (string direction){
		Debug.Log ("Plane control: " + direction);

		if(state == "flightPlane"){
			if (direction == "left") {
				cessna.headLeft (70);
			} else if (direction == "right") {
				cessna.headRight (70);
			} else if (direction == "up") {
				cessna.up (70);
			} else if (direction == "down") {
				cessna.down (70);
			}
		} else if(state == "driveBus"){
			if (direction == "left") {
				bus.left (20);
			} else if (direction == "right") {
				bus.right(20);
			} 
		}
	}

	public void increaseSpeed(int amount){
		if(state == "driveBus"){
			bus.increaseSpeed (20);
		} else if(state == "flightPlane"){
			cessna.increaseSpeed (amount);
		}
	}

	public int getScore (){
		return score;
	}

	public void addScore(int inc){
		AudioSource.PlayClipAtPoint (beep, Camera.main.transform.position);
		score = score + inc;
	}

	public void runwayPlaced(){
		if(state == "putRunway"){
			addScore (100);
			gui.setMessage ("Coloque a torre de controlo");
			state = "putTower";
		}
	}

	public void towerPlaced(){
		if(state == "putTower"){
			addScore (200);
			gui.setMessage ("Coloque o Bus");
			state = "putBus";
		}
	}

	public void busPlaced(){
		if(state == "putBus"){
			addScore (300);
			gui.setMessage ("Conduza o Bus até o avião");
			state = "driveBus";
			bus.turnOn();
		}
	}

	public void busArrived(){
		if(state == "driveBus"){
			addScore (500);
			gui.setMessage ("Agora pilote o avião");
			state = "flightPlane";
			cessna.turnOn ();
		}
	}

	public string getState(){
		return state;
	}
}