using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    public TextMeshProUGUI _scoreText;
    public ScoreManager _scoreManager;

	public void Update()
	{
		_scoreText.text = "Score: " + _scoreManager.GetScore();
	}

}
