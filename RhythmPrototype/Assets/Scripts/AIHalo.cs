using UnityEngine;
using System.Collections;

public class AIHalo : MonoBehaviour {

	public GameObject AiHalo;
	public GameObject AiHalo2;

	public float wait;
	public float wait2;

	// Use this for initialization
	void Start () {

		wait = 0.5f;
		wait2 = 0.24f;
	
	}
	
	// Update is called once per frame
	void Update () {

	//Conversation 1

	if(Time.time > 7.9 && Time.time < 8.1)
		{
		AiHalo.SetActive(true);
		Invoke("TurnOff",wait);
		}

	if(Time.time > 8.4 && Time.time < 8.6)
		{
		AiHalo2.SetActive(true);
		Invoke("TurnOff2",wait);
		}
		
	//

	if(Time.time > 8.9 && Time.time < 9.1)
		{
		AiHalo.SetActive(true);
		Invoke("TurnOff",wait);
		}
		
	if(Time.time > 9.4 && Time.time < 9.6)
		{
		AiHalo2.SetActive(true);
		Invoke("TurnOff2",wait);
		}

	//

	if(Time.time > 9.9 && Time.time < 10.1)
		{
		AiHalo.SetActive(true);
		Invoke("TurnOff",wait2);
		}

	if(Time.time > 10.15 && Time.time < 10.35)
		{
		AiHalo.SetActive(true);
		Invoke("TurnOff",wait);
		}
		
	if(Time.time > 10.4 && Time.time < 10.6)
		{
		AiHalo2.SetActive(true);
		Invoke("TurnOff2",wait);
		}

	//

	if(Time.time > 10.9 && Time.time < 11.1)
		{
		AiHalo.SetActive(true);
		Invoke("TurnOff",wait);
		}
				
	if(Time.time > 11.4 && Time.time < 11.6)
		{
		AiHalo2.SetActive(true);
		Invoke("TurnOff2",wait);
		}


	//Conversation 2

	if(Time.time > 19.9 && Time.time < 20.1)
		{
			AiHalo.SetActive(true);
			Invoke("TurnOff",wait);
		}

	if(Time.time > 20.4 && Time.time < 20.6)
		{
			AiHalo2.SetActive(true);
			Invoke("TurnOff2",wait);
		}

	if(Time.time > 20.9 && Time.time < 21.1)
		{
			AiHalo.SetActive(true);
			Invoke("TurnOff",wait2);
		}

	if(Time.time > 20.15 && Time.time < 20.35)
		{
			AiHalo.SetActive(true);
			Invoke("TurnOff",wait);
		}

	if(Time.time > 21.4 && Time.time < 21.6)
		{
			AiHalo2.SetActive(true);
			Invoke("TurnOff2",wait);
		}

	if(Time.time > 21.9 && Time.time < 2.1)
		{
			AiHalo.SetActive(true);
			Invoke("TurnOff",wait);
		}

	if(Time.time > 22.4 && Time.time < 22.6)
		{
			AiHalo2.SetActive(true);
			Invoke("TurnOff2",wait);
		}

	if(Time.time > 22.9 && Time.time < 23.1)
		{
			AiHalo.SetActive(true);
			Invoke("TurnOff",wait2);
		}

	if(Time.time > 23.15 && Time.time < 23.35)
		{
			AiHalo.SetActive(true);
			Invoke("TurnOff",wait2);
		}

	if(Time.time > 23.4 && Time.time < 23.6)
		{
			AiHalo2.SetActive(true);
			Invoke("TurnOff2",wait);
		}




	//Conversation 3


	if(Time.time > 31.9 && Time.time < 32.1)
		{
			AiHalo2.SetActive(true);
			Invoke("TurnOff2",wait);
		}
	
	if(Time.time > 32.4 && Time.time < 32.6)
		{
			AiHalo2.SetActive(true);
			Invoke("TurnOff2",wait);
		}
	
	if(Time.time > 32.9 && Time.time < 33.1)
		{
			AiHalo2.SetActive(true);
			Invoke("TurnOff2",wait);
		}

	if(Time.time > 33.4 && Time.time < 33.6)
		{
			AiHalo.SetActive(true);
			Invoke("TurnOff",wait);
		}

	if(Time.time > 33.9 && Time.time < 34.1)
		{
			AiHalo2.SetActive(true);
			Invoke("TurnOff2",wait2);
		}
		
	if(Time.time > 34.15 && Time.time < 34.35)
		{
			AiHalo2.SetActive(true);
			Invoke("TurnOff2",wait2);
		}
		
	if(Time.time > 34.4 && Time.time < 34.6)
		{
			AiHalo2.SetActive(true);
			Invoke("TurnOff2",wait2);
		}

	if(Time.time > 34.65 && Time.time < 34.85)
		{
			AiHalo2.SetActive(true);
			Invoke("TurnOff2",wait2);
		}

	if(Time.time > 35.15 && Time.time < 35.35)
		{
			AiHalo2.SetActive(true);
			Invoke("TurnOff2",wait2);
		}

	if(Time.time > 35.4 && Time.time < 35.6)
		{
			AiHalo.SetActive(true);
			Invoke("TurnOff",wait);
		}

	
	}

	void TurnOff ()
	{
		AiHalo.SetActive(false);
	}

	void TurnOff2 ()
	{
		AiHalo2.SetActive(false);
	}


}
