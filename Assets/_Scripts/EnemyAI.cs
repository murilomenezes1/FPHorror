using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class EnemyAI : MonoBehaviour
{


	public GameObject EnemyDestination;
	NavMeshAgent EnemyAgent;
	public bool attackTrigger;
	public bool isAttacking = false;
	public GameObject Zombie;
	public GameObject ActionText;
	public AudioSource DeathSound;
	public GameObject DeathPanel;

    // Start is called before the first frame update
    void Start()
    {

    	EnemyAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {

    	EnemyAgent.SetDestination(EnemyDestination.transform.position);


    }

    void OnTriggerEnter()
    {
    	DeathSound.Play();

    	StartCoroutine(Reset());
    	
    }

    IEnumerator Reset()
    {

    	DeathPanel.SetActive(true);
    	EnemyDestination.GetComponent<FirstPersonController>().enabled = false;
    	yield return new WaitForSeconds(3f);
    	EnemyDestination.GetComponent<FirstPersonController>().enabled = true;
    	SceneManager.LoadScene("MainGame");
    	
}	
    }
  
