using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnTrigger : MonoBehaviour
{
	public AudioClip ClipToPlay;

	private AudioSource _AudioPlayer;

	private void Start()
	{
		_AudioPlayer = GameObject.Find("AudioPlayer").GetComponent<AudioSource>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			_AudioPlayer.PlayOneShot(ClipToPlay);
			print("Played sound!");
		}
	}
}
