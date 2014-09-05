using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayAudio : MonoBehaviour {


	public AudioClip bassDrum;
	public AudioClip snareDrum;

	public GameObject audioSource;

	private GameObject snareAudio = null;
	private GameObject bassAudio = null;

	private List<GameObject> audioSources = new List<GameObject>();
	private List<int> audioLocations = new List<int>();
	private int i = 0;
	void Start()
	{
		snareAudio = Instantiate(audioSource, transform.position, transform.rotation) as GameObject;
		snareAudio.audio.clip = snareDrum;

		bassAudio = Instantiate(audioSource, transform.position, transform.rotation) as GameObject;
		bassAudio.audio.clip = bassDrum;

	}

	// Update is called once per frame
	void Update () {

		//Debug.Log(AudioSettings.dspTime);
		if(Time.time < 7 || Time.time > 12)
		{
		if(Input.GetButtonDown("Bass"))
		{
			bassAudio.audio.Play();
		}
		if(Input.GetButtonDown("Snare"))
		{
			snareAudio.audio.Play();
		}
		if(Input.GetButtonDown("HighHat"))
		{
			snareAudio.audio.Play();
		}
		}
		//Debug.Log(audio.timeSamples);
	
	}
}
