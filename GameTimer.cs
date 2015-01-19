using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameTimer : MonoBehaviour {

	public static int timer;
	public float timeElapsed;
	bool youlost;
	
	Text text;
	
	
	void Awake ()
	{
		//Sets up the timer and references the text object
		text = GetComponent <Text> ();
		timer = 160;
	}
	
	void Update ()
	{
		//code used to regulate the timer
		timeElapsed += Time.deltaTime;
		text.text = "Timer: " + (timer - (int)timeElapsed);
		
		//if timer >= 0 you loose!
		if ((timer - timeElapsed) <= 0) 
		{
			YouLoose();
		}
	}

	void YouLoose()
	{
		//loads the youlost scene
		Application.LoadLevel ("YouLost");
	}

}