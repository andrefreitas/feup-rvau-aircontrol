using UnityEngine;
using System.Collections;

public class terrainScript : MonoBehaviour {

	gameScript game;
	GameObject gameScriptObject;


	void Start () {
		// Get the GameScript reference
		gameScriptObject = GameObject.Find("GameScript");
		game = (gameScript) gameScriptObject.GetComponent(typeof(gameScript));

	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnBecameVisible() {
		game.startGame ();
	}
}
