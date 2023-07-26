using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	private int score;


	public void AddPoints(int amountOfPoints)
	{
		score += amountOfPoints;
		print("You have: " + score);
	}

}
