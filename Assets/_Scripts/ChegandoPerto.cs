using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class ChegandoPerto : MonoBehaviour
{
public GameObject Player;
	public GameObject Speech;


	void OnTriggerEnter()
	{
		StartCoroutine(ScenePlayer ());
	}

	IEnumerator ScenePlayer()
	{

		Speech.GetComponent<Text>().text = "Acho que estou chegando perto...";
		yield return new WaitForSeconds(2);
		Speech.GetComponent<Text>().text = "";

	}
}
