using UnityEngine;
using System.Collections;

public class TowerScript : MonoBehaviour {
	GameScript game;
	
	void Start () {
		game = (GameScript)  GameObject.Find("GameScript").GetComponent(typeof(GameScript));
	}
	
	void OnBecameVisible() {
		Debug.Log ("Torre colocada!!!!");
		game.towerPlaced ();
	}
}