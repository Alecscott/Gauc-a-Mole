﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
	public AudioClip[] audioClips;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}

	public void PlayAudioClip(string clipName)
	{
		foreach (AudioClip clip in audioClips) 
		{
			if (clip.name == clipName) 
			{
				audioSource.PlayOneShot (clip);
			}
		}
	}

	public void PlayAudioClipRepeated(string clipName)
	{
		foreach (AudioClip clip in audioClips) 
		{
			if (clip.name == clipName) 
			{
				audioSource.PlayOneShot(clip);
			}
		}
	}

	public void EndAudioClipRepeated(string clipName)
	{
		foreach (AudioClip clip in audioClips) 
		{
			if (clip.name == clipName) 
			{
				
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
