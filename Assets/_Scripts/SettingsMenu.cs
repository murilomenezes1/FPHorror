using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;



[RequireComponent(typeof (Slider))]

public class SettingsMenu : MonoBehaviour
{

	Slider Slider
	{

		get {return GetComponent<Slider>();}
	}


	public AudioMixer mixer;
	public string VolumeName;

	public void UpdateValueOnChange(float value)
	{
		mixer.SetFloat(VolumeName,value);
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
