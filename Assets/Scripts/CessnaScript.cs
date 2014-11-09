using UnityEngine;
using System.Collections;

public class CessnaScript : MonoBehaviour {

	public float speed;
	public string state;
	
	void Start () {
		speed = 1200;
		state = "off";
	
	}

	void Update () {

		if (state == "on") {
			forward (speed, gameObject);
			keyboardControl();
		}

	}


	void keyboardControl(){
		float horizontal = Input.GetAxis ("Horizontal");
		if (horizontal > 0) {
			headLeft (50, gameObject);
		} else if (horizontal < 0) {
			headRight (50, gameObject);
		}
		float vertical = Input.GetAxis ("Vertical");

		if (vertical > 0) {
			down(50, gameObject);
		} else if (vertical < 0) {
			up (50, gameObject);
		}
	}

	public void turnOn(){
		audio.Play ();
		state = "on";
	}


	public void forward(float speed, GameObject go){
		go.transform.Translate (speed * Time.deltaTime, 0 , 0);
	}

	public void up(float angle, GameObject go){
		go.transform.Rotate (0, 0, angle * Time.deltaTime);
	}

	public void down(float angle, GameObject go){
		go.transform.Rotate (0, 0, -angle * Time.deltaTime);
	}

	public void left(float angle, GameObject go){
		go.transform.Rotate (-angle * Time.deltaTime, 0, 0 );
	}

	public void right(float angle, GameObject go){
		go.transform.Rotate (angle * Time.deltaTime, 0, 0 );
	}

	public void headLeft(float angle, GameObject go){
		go.transform.Rotate (0, -angle * Time.deltaTime, 0 );
	}

	public void headRight(float angle, GameObject go){
		go.transform.Rotate (0, angle * Time.deltaTime, 0 );
	}
	

}
