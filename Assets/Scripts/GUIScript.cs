using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {

	GUIStyle messagesStyle;
	GUIStyle scoreStyle;
	public Texture2D messageTexture;
	public Texture2D scoreTexture;
	

	// Use this for initialization
	void Start () {

		initStyles ();



	
	}

	void initStyles(){
		messagesStyle = new GUIStyle ();
		messagesStyle.fontSize = 80;
		messagesStyle.richText = true;
		messagesStyle.normal.textColor = Color.white;
		messagesStyle.normal.background = messageTexture;
		messagesStyle.padding = new RectOffset(300,0, 55, 20);
		messagesStyle.alignment = TextAnchor.UpperLeft;

		scoreStyle = new GUIStyle ();
		scoreStyle.fontSize = 80;
		scoreStyle.richText = true;
		scoreStyle.normal.textColor = Color.white;
		scoreStyle.normal.background = scoreTexture;
		scoreStyle.padding = new RectOffset(0,0, 55, 20);
		scoreStyle.alignment = TextAnchor.UpperCenter;




	}

	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {

	}

	void displayScore(int score){
		GUI.Label(new Rect(50, 50, 698, 200), score.ToString() + " pontos", scoreStyle);
	}

	void displayMessage(string message){
		GUI.Label(new Rect(100, 100, 1397, 202), message, messagesStyle);
	}
}
