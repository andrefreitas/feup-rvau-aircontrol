using UnityEngine;
using System.Collections;

public class CessnaScript : MonoBehaviour {
	public float speed;


	// Use this for initialization
	void Start () {
		speed = 80;
		audio.Play ();
	
	}
	
	// Update is called once per frame
	void Update () {
		forward (300);
		keyboardControl ();
	
	}


	void keyboardControl(){
		float horizontal = Input.GetAxis ("Horizontal");
		if (horizontal > 0) {
			left (20);
		} else if (horizontal < 0) {
			right (20);
		}
		float vertical = Input.GetAxis ("Vertical");

		if (vertical > 0) {
			down(20);
		} else if (vertical < 0) {
			up (20);
		}
	}


	void forward(float speed){
		transform.Translate (speed * Time.deltaTime, 0 , 0);
	}

	void up(float angle){
		transform.Rotate (0, 0, angle * Time.deltaTime);
	}

	void down(float angle){
		transform.Rotate (0, 0, -angle * Time.deltaTime);
	}

	void left(float angle){
		transform.Rotate (-angle * Time.deltaTime, 0, 0 );
	}

	void right(float angle){
		transform.Rotate (angle * Time.deltaTime, 0, 0 );
	}

}
