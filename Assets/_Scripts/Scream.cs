using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scream : MonoBehaviour
{

	public AudioSource ScreamSound;
void OnTriggerEnter()
	{
		ScreamSound.Play();
	}

}
