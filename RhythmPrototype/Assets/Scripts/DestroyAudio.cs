using UnityEngine;
using System.Collections;

public class DestroyAudio : MonoBehaviour {
	

	// Update is called once per frame
	void LateUpdate () {

		if(!audio.isPlaying)
		{
			Destroy(gameObject);
		}
	
	}
}
