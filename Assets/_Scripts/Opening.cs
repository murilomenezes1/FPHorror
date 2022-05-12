using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class Opening : MonoBehaviour
{
    public GameObject Player;
    public GameObject Fade;
    public GameObject Speech;

    void Start()
    {

    	Player.GetComponent<FirstPersonController>().enabled = false;
    	StartCoroutine (ScenePlayer ());

        
    }

    IEnumerator ScenePlayer()
    {

    	yield return new WaitForSeconds(1.5f);
    	Fade.SetActive(false);
    	Speech.GetComponent<Text>().text = "Onde estou?";
    	yield return new WaitForSeconds(2.5f);
    	Speech.GetComponent<Text>().text = "Preciso sair daqui.";
    	yield return new WaitForSeconds(1.5f);
    	Speech.GetComponent<Text>().text = "";
    	Player.GetComponent<FirstPersonController>().enabled = true;




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
