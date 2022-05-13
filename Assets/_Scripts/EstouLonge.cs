using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class EstouLonge : MonoBehaviour
{
public GameObject Player;
	public GameObject Speech;


	void OnTriggerEnter()
	{
		StartCoroutine(ScenePlayer ());
	}

	IEnumerator ScenePlayer()
	{

		Speech.GetComponent<Text>().text = "Sinto que estou longe da saida...";
		yield return new WaitForSeconds(2);
		Speech.GetComponent<Text>().text = "";

	}
}
