using UnityEngine;
using System;
using System.Collections;

public class ScoreManager {

	// Variable to hold the score during game play
	private static int currentScore;

	// Use this for initialization
	public ScoreManager()
	{
		currentScore = 0;
	}

	// Returns the current score
	public static int GetScore()
	{
		return currentScore;
	}
	
	// Increments the score my the given amount
	//	Also returns the score if needed
	public static int AddToScore(float amountToAdd)
	{
		currentScore += (int)amountToAdd;
		return currentScore;
	}
}
