using UnityEngine;
using System.Collections;

public class RunwayScript : MonoBehaviour {
	GameScript game;

	void Start () {
		game = (GameScript)  GameObject.Find("GameScript").GetComponent(typeof(GameScript));
	}

	void OnBecameVisible() {
		game.startGame ();
	}
}