using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
		public AudioClip impact;
		AudioSource audioSource;

		void Start()
		{
			audioSource = GetComponent<AudioSource>();
		}

		void OnCollisionEnter()
		{
			audioSource.PlayOneShot(impact, 0.7F);

		}
	}
