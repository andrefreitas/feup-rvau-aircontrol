using UnityEngine;
using System.Collections;

public class movementControl : MonoBehaviour {

	public GameObject plane;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		if (this.name == "buttonLeft") {
			Debug.Log ("A ir para a esquerda");
			//plane.GetComponent<CessnaScript>().headLeft(50);
		}
		else if (this.name == "buttonRight") {
			Debug.Log("A ir para a direita");
			//plane.GetComponent<CessnaScript>().headRight(50);
		}
		else if (this.name == "buttonUp") {
			Debug.Log("A ir para cima");
			//plane.GetComponent<CessnaScript>().up(50);
		}
		else if (this.name == "buttonDown") {
			Debug.Log("A ir para baixo");
			//plane.GetComponent<CessnaScript>().down(50);
	}

	}
}
