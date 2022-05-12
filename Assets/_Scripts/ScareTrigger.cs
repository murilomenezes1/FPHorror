using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class ScareTrigger : MonoBehaviour
{
    public GameObject Player;
	public GameObject Zombie;
	public GameObject Trigger;
	public GameObject Speech;
	public AudioSource ScareSound;


	void OnTriggerEnter() 
	{
		GetComponent<BoxCollider>().enabled = false;
		Player.GetComponent<FirstPersonController>().enabled = false;
		Zombie.SetActive(true);
		Zombie.GetComponent<Animation>().Play("Z_Run");
		ScareSound.Play();
		StartCoroutine(KillZombie());

	}

	IEnumerator KillZombie()
	{
		Speech.GetComponent<Text>().text = "QUE P* É AQUELA?!";
		yield return new WaitForSeconds(2.5f);
		Speech.GetComponent<Text>().text = "";
		Player.GetComponent<FirstPersonController>().enabled = true;
		Zombie.SetActive(false);
		Trigger.SetActive(false);
	}
}
