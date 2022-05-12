using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{

	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject FakeFlashlight;
	public GameObject RealFlashlight;
	public GameObject ScareTrigger;

    // Update is called once per frame
    void Update()
    {

    	TheDistance = PlayerCasting.DistanceFromTarget;
        
    }

    void OnMouseOver()
    {

    	if (TheDistance <= 1) {

    		ActionText.GetComponent<Text>().text = "Pegar lanterna";
    		ActionDisplay.SetActive(true);
    		ActionText.SetActive(true);

    	}

    	if (Input.GetKeyDown(KeyCode.E)) {

    		if (TheDistance <= 1) {

    			this.GetComponent<BoxCollider>().enabled = false;

    			ActionDisplay.SetActive(false);
    			ActionText.SetActive(false);
    			FakeFlashlight.SetActive(false);
    			RealFlashlight.SetActive(true);
    			ScareTrigger.SetActive(true);
    		}
    	}
    }

    void OnMouseExit() 
    {
    	ActionDisplay.SetActive(false);
    	ActionText.SetActive(false);
    }
}

