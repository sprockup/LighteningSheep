using UnityEngine;
using System;
using System.Collections;

public class ScoreManager {

	private int currentScore;
	private int highScore;

	// Use this for initialization
	public ScoreManager()
	{
		currentScore = 0;
		highScore = 0;
	}

	int GetScore()
	{
		return currentScore;
	}
	
	int AddToScore(int amountToAdd)
	{
		currentScore += amountToAdd;
		return currentScore;
	}
}
