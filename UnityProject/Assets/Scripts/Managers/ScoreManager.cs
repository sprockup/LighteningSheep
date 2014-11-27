using UnityEngine;
using System;
using System.Collections;

public class ScoreManager {

	private static int currentScore;
	//private static int highScore;

	private static ScoreManager theScoreManager;

	// Use this for initialization
	public ScoreManager()
	{
		currentScore = 0;
		//highScore = 0;
	}

	/*public ScoreManager GetInstance()
	{
		if (null == theScoreManager)
		{
			theScoreManager = new ScoreManager();
		}
		
		return theScoreManager;
		
	}*/

	public static int GetScore()
	{
		return currentScore;
	}
	
	public static int AddToScore(float amountToAdd)
	{
		currentScore += (int)amountToAdd;
		return currentScore;
	}
}
