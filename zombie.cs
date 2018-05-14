using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class zombie : MonoBehaviour {
	NavMeshAgent nav;
	public Transform target;
	Animator anim;
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination (target.position);
		//void OnCollisonEnter(Collison arg){
		//a
		//nav.enabled=false; 
	//}
	}

	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag == "bullet") {
			//Destroy (gameObject);
			anim.SetFloat("dead",0.5f);
			nav.enabled=false; 
		}
	}
}
