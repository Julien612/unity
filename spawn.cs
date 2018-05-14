using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
	public GameObject zombie;
	Transform tr;
	public Transform Camera;
	GameObject clone;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawner", 5f, 5f);
		tr = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void spawner (){
		clone=Instantiate (zombie, tr.position, tr.rotation);
		clone.GetComponent<zombie> ().target=Camera;

	}

}
