using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayAudio : MonoBehaviour {


	public AudioClip bassDrum;
	public AudioClip snareDrum;

	public GameObject audioSource;

	private GameObject snareAudio = null;
	private GameObject bassAudio = null;

	private float snareHitTime = 0.0f;
	private float lastSnareHitTime = 0.0f;
	private float beat = 0.5f;

	private float metronomeTime = 0.0f;

	private bool hit = false;

	private int i = 0;
	void Start()
	{
		snareAudio = Instantiate(audioSource, transform.position, transform.rotation) as GameObject;
		snareAudio.audio.clip = snareDrum;

		bassAudio = Instantiate(audioSource, transform.position, transform.rotation) as GameObject;
		bassAudio.audio.clip = bassDrum;

	}
	void Awake()
	{
		InvokeRepeating("SnareHit", 0, .5f);
	}
	void SnareHit()
	{
		metronomeTime = Time.time;
		//if(Input.GetButton("Snare"))
		//{
		//	snareAudio.audio.Play();
		//}
		//snareAudio.audio.Play();
	}

	void BassHit()
	{

	}

	// Update is called once per frame
	void Update () {

		if(Time.time > 12 && Time.time < 20)
		{
			if(Input.GetButtonDown("Snare"))
			{
				snareHitTime = Time.time;

					if((snareHitTime - metronomeTime) < .5f)
					i++;

					snareAudio.audio.Play();
			}

			if(Input.GetButtonDown("Bass"))
			{
				bassAudio.audio.Play();
			}
		}
		//if(Input.GetButtonDown("HighHat"))
		//{
		//	snareAudio.audio.Play();
		//}
		Debug.Log(i);
		//Debug.Log(audio.timeSamples);
	
	}
}
