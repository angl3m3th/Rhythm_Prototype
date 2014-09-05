using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayAudio : MonoBehaviour {

	public GameObject audioSource;

	public GameObject playerHalo;
	public GameObject playerHaloBass;

	//Snare
	public AudioClip snareDrum;
	private GameObject snareAudio = null;
	private float snareHitTime = 0.0f;
	private int i = 0;

	//Bass
	public AudioClip bassDrum;
	private GameObject bassAudio = null;
	private float bassHitTime = 0.0f;
	private int b = 0;

	private float snareMetronomeTime = 0.0f;
	private float bassMetronomeTime = 0.0f;

	private int responses = 0;


	#region Start (Instantiate snare and bass audio sources)
	void Start()
	{
		snareAudio = Instantiate(audioSource, transform.position, transform.rotation) as GameObject;
		snareAudio.audio.clip = snareDrum;

		bassAudio = Instantiate(audioSource, transform.position, transform.rotation) as GameObject;
		bassAudio.audio.clip = bassDrum;

	}
	#endregion

	#region Metronome
	void Awake()
	{
		InvokeRepeating("SnareMetronome", 0, .5f);
		InvokeRepeating("BassMetronome", 0, .25f);
	}

	void SnareMetronome()
	{
		snareMetronomeTime = Time.time;
	}

	void BassMetronome()
	{
		bassMetronomeTime = Time.time;
	}
	#endregion


	// Update is called once per frame
	void Update () {

		//First Response
		if(Time.time > 12 && Time.time < 20)
		{
			PlayerResponse();
		}
		if(Time.time > 20 && Time.time < 24)
		{
			playerHalo.SetActive(false);
			playerHaloBass.SetActive(false);
		}
		//Second Response
		if(Time.time > 24 && Time.time < 32)
		{
			PlayerResponse();
		}
		if(Time.time > 32 && Time.time < 36)
		{
			playerHalo.SetActive(false);
			playerHaloBass.SetActive(false);
		}
		if(Time.time > 36 && Time.time < 44)
		{
			PlayerResponse();
		}




		//Debug.Log(i);
		//Debug.Log(b);

		if (responses >= 2 && Time.time > 44)
		{
			Debug.Log ("You win");
		}

	
	}

	void PlayerResponse ()
	{
		//Check if the snare has been hit
		if(Input.GetButtonDown("Snare"))
		{
			//Get the time it was hit
			snareHitTime = Time.time;
			
			//compare to see if it was hit on beat
			if((snareHitTime - snareMetronomeTime) < .5f)
				i++;
			
			//Play the snare audio clip
			snareAudio.audio.Play();
			playerHalo.SetActive(true);
		}
		if(Input.GetButtonUp("Snare"))
		{
			playerHalo.SetActive(false);
		}
		
		//Check if the bass was hit
		if(Input.GetButtonDown("Bass"))
		{
			bassHitTime = Time.time;
			
			if((bassHitTime - bassMetronomeTime) < .25f)
				b++;
			
			bassAudio.audio.Play();
			playerHaloBass.SetActive(true);
		}
		if(Input.GetButtonUp("Bass"))
		{
			playerHaloBass.SetActive(false);
		}
		
		if ((i > 4) && (b > 4))
		{
			responses++;
			i = 0;
			b = 0;
		}
	}
}
