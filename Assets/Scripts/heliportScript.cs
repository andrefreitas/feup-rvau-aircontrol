using UnityEngine;
using System.Collections;

public class heliportScript : MonoBehaviour {
	gameScript game;

	// Use this for initialization
	void Start () {
		game = (gameScript) GameObject.Find("GameScript").GetComponent(typeof(gameScript));

	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnBecameVisible() {
		Debug.Log ("Visible heliport");
		game.heliportIsPlaced();
	}
}
