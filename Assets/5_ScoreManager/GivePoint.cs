using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GivePoint : MonoBehaviour
{
	public int AmountOfPoints = 1;
	private ScoreManager _scoreManager;

	private void Start()
	{
		_scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			_scoreManager.AddPoints(AmountOfPoints);
			Destroy(gameObject);
		}
	}
}
