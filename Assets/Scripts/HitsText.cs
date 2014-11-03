using UnityEngine;
using System.Collections;

public class HitsText : MonoBehaviour {


	void Start () {
		this.guiText.fontSize = 36;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setText(string text){
		this.guiText.text = text;
	}
}
