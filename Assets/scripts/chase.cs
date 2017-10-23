using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chase : MonoBehaviour {
	UnityEngine.AI.NavMeshAgent nav;
	Transform player;  
	public float dist;
	public Text loseText;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
		nav = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
		loseText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		dist = Vector3.Distance(player.position, transform.position);

		if(dist <= 60)
		{
			nav.SetDestination (player.position);

		
			if (dist < 1.2) {
				loseText.text = "You lose";
				Destroy (GameObject.FindGameObjectWithTag ("Player"));
			}
			
		}

	}
}
