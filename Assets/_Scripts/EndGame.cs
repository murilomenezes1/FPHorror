using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
	
	public GameObject EndScreen;
	public AudioSource EndMusic;
	public AudioSource LevelMusic;
	public GameObject Player;

	void OnTriggerEnter()
	{
		
		StartCoroutine(End());


	}

	IEnumerator End()
	{

		EndScreen.SetActive(true);
		Player.GetComponent<FirstPersonController>().enabled = false;
		LevelMusic.Pause();
		EndMusic.Play();
		yield return new WaitForSeconds(2f);
		
		SceneManager.LoadScene("MainMenu");



	}
}
