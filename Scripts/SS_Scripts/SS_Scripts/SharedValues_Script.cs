

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SharedValues_Script : MonoBehaviour
{
	//Public Var
	public GUIStyle mystyle;
	public Text scoreText, GameOverText, FinalScoreText, ReplayText, CoinsText, SpeedText, AngleText, LazerText, coorText;

	//Public Shared Var
	public static int score = 0;            //Total in-game Score
	public static bool gameover = false;
	public static int howmany;
	public GameObject player;



	// Use this for initialization
	void Start()
	{
		gameover = false;
		score = 0;

	}




	// Fixed Update is called one per specific time
	void FixedUpdate ()
	{
		scoreText.text = "Score: " + score;//Update the GUI Score
		CoinsText.text = "Coins: " + howmany;
		coorText.text = "x, y " + player.transform.position;
		SpeedText.text = "Speed " + test2.speed;
		AngleText.text = "Angle " + Rotator.CurrentRotation;

		//Excute when the GameOver Trigger is True
		if (gameover == true)
		{
			
			ReplayText.text = "R = REPLAY";
			GameOverText.text = "You're dead :)";
			FinalScoreText.text = "Score" + score;



		}
		
	}
	


}
