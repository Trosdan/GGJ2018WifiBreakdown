using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour {

	public AudioSource soundSource;
	public AudioSource backgroundMusic;




	// Use this for initialization
	void Start () {
		backgroundMusic.time = PlayerPrefs.GetFloat ("BackgroundSound");
		backgroundMusic.Play ();
	}
	
	// Update is called once per frame
	void Update () {
			
	}



	public void PlayClip(AudioClip clip){
		soundSource.clip = clip;
		soundSource.Play();
	}

	public void PlayClipRandom(AudioClip[] clips){
		int size = clips.Length;
		soundSource.clip = clips [Random.Range (0, size)];
	}
}
