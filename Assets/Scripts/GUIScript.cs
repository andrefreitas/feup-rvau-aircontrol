using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {

	GUIStyle messagesStyle;
	GUIStyle scoreStyle;
	public Texture2D messageTexture;
	public Texture2D scoreTexture;
	public string message;
	public int score;
	public bool showScore = false;
	GameScript game;
	

	// Use this for initialization
	void Start () {
		message = "Coloque os marcadores";
		initStyles ();
		game = (GameScript)GameObject.Find ("GameScript").GetComponent (typeof(GameScript));

	}

	void initStyles(){
		// Messages
		messagesStyle = new GUIStyle ();
		messagesStyle.fontSize = 80;
		messagesStyle.richText = true;
		messagesStyle.normal.textColor = Color.white;
		messagesStyle.normal.background = messageTexture;
		messagesStyle.padding = new RectOffset(300,0, 55, 20);
		messagesStyle.alignment = TextAnchor.UpperLeft;

		// Score
		scoreStyle = new GUIStyle ();
		scoreStyle.fontSize = 80;
		scoreStyle.richText = true;
		scoreStyle.normal.textColor = Color.white;
		scoreStyle.normal.background = scoreTexture;
		scoreStyle.padding = new RectOffset(0,0, 55, 20);
		scoreStyle.alignment = TextAnchor.UpperCenter;

	}
	
	void OnGUI () {

		if (showScore) {
			score = game.getScore();
			displayScore (score);		
		} else {
			displayMessage ("Coloque o marcador da pista");
		}

		if(GUI.RepeatButton(new Rect(Screen.width - 350, Screen.height - 250, 100, 100 ), " ")) {
			game.control("left");
		}

		if(GUI.RepeatButton(new Rect(Screen.width - 150, Screen.height - 250, 100, 100 ), " ")) {
			game.control("right");
		}

		if(GUI.RepeatButton(new Rect(Screen.width - 250, Screen.height - 350, 100, 100 ), " ")) {
			game.control("down");
		}

		if(GUI.RepeatButton(new Rect(Screen.width - 250, Screen.height - 150, 100, 100 ), " ")) {
			game.control("up");
		}

		if(GUI.RepeatButton(new Rect(Screen.width - 550, Screen.height - 250, 100, 100 ), " ")) {
			game.increaseSpeed(100);
		}

		if(GUI.RepeatButton(new Rect(Screen.width - 700, Screen.height - 250, 100, 100 ), " ")) {
			game.increaseSpeed(-100);
		}


	}

	public void displayScore(int score){
		GUI.Label(new Rect(50, 50, 698, 200), score.ToString() + " pontos", scoreStyle);
	}

	public void displayMessage(string message){
		GUI.Label(new Rect(100, 100, 1397, 202), message, messagesStyle);
	}

	public void startGame(){
		message = "Começou o jogo!";
		showScore = true;
	}
}
