using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayAudio : MonoBehaviour {


	public AudioClip bassDrum;
	public AudioClip snareDrum;

	public GameObject audioSource;

	private List<GameObject> audioSources = new List<GameObject>();
	private List<int> audioLocations = new List<int>();
	private int i = 0;
	
	// Update is called once per frame
	void Update () {
		i=0;

		if(Input.GetButtonDown("Bass"))
		{
			GameObject newAudio = Instantiate(audioSource, transform.position, transform.rotation) as GameObject;
			newAudio.audio.clip = bassDrum;
			newAudio.audio.Play();
		}
		if(Input.GetButtonDown("Snare"))
		{
			GameObject newAudio = Instantiate(audioSource, transform.position, transform.rotation) as GameObject;
			newAudio.audio.clip = snareDrum;
			newAudio.audio.Play();
		}
		if(Input.GetButtonDown("HighHat"))
		{
			GameObject newAudio = Instantiate(audioSource, transform.position, transform.rotation) as GameObject;
			newAudio.audio.clip = snareDrum;
			newAudio.audio.Play();
		}
	
	}
}
