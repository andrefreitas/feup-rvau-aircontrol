using UnityEngine;
using System.Collections;

public class CessnaScript : MonoBehaviour {

	public float speed;
	public string state;
	public const float MAX_SPEED = 1500;
	public const float MIN_SPEED = 300;
	GameScript game;

	void Start () {
		speed = 0;
		state = "off";
		game = (GameScript)  GameObject.Find("GameScript").GetComponent(typeof(GameScript));
	}

	void Update () {
		if (state == "on") {
			forward (speed);
		}
	}

	public void turnOn(){
		audio.Play ();
		state = "on";
	}
	
	public void forward(float speed){
		transform.Translate (speed * Time.deltaTime, 0 , 0);
	}

	public void up(float angle){
		transform.Rotate (0, 0, angle * Time.deltaTime);
	}

	public void down(float angle){
		transform.Rotate (0, 0, -angle * Time.deltaTime);
	}

	public void left(float angle){
		transform.Rotate (-angle * Time.deltaTime, 0, 0 );
	}

	public void right(float angle){
		transform.Rotate (angle * Time.deltaTime, 0, 0 );
	}

	public void headLeft(float angle){
		transform.Rotate (0, -angle * Time.deltaTime, 0 );
	}

	public void headRight(float angle){
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
