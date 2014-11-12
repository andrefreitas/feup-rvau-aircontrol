using UnityEngine;
using System.Collections;

public class BusScript : MonoBehaviour {
	GameScript game;
	Vector3 airplane;

	public float speed;
	public string state;
	const float MAX_SPEED = 200;
	const float MIN_SPEED = 0;
	
	void Start () {
		speed = 0;
		state = "off";
		game = (GameScript)  GameObject.Find("GameScript").GetComponent(typeof(GameScript));

		airplane = GameObject.Find ("Cessna").transform.position;
 
	}
	
	void OnBecameVisible() {
		game.busPlaced ();
	}

	void Update () {
		if (state == "on") {
			forward (speed);
		}

		float distance = Vector3.Distance (airplane, transform.position);


		Debug.Log (distance);

		if (distance < 90) {
			game.busArrived();
			speed = 0;
			turnOff();
		}

	}

	public void turnOff() {
		audio.Stop ();
	}
	
	public void turnOn(){
		state = "on";
		audio.Play ();
	}

	public void forward(float speed){
		transform.Translate (0, 0 , speed * Time.deltaTime);
	}
	
	public void left(float angle){
		transform.Rotate (0, -angle * Time.deltaTime, 0 );
	}
	
	public void right(float angle){
		transform.Rotate (0, angle * Time.deltaTime, 0 );
	}

	public void increaseSpeed(float amount){
		if ((speed + amount) > MAX_SPEED) {
			speed = MAX_SPEED;
		} else if ((speed + amount) < MIN_SPEED){
			speed = MIN_SPEED;
		} else{
			speed = speed + amount;
		}
	}
	
}