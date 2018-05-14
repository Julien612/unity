using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {
	Transform tr;
	Rigidbody rb;
	public Transform dulo;
	public Rigidbody obj;
	 Rigidbody clone;
	public Camera zoomCam;
	Camera myCam;
	float h;
	float f;
	float d;
	float mouse;
	float ver;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		tr = GetComponent<Transform> ();
		InvokeRepeating ("spawn", 4f, 10f);
		myCam = GetComponent<Camera> ();
	
	}
	// Update is called once per frame
	void Update () {
		ver = Input.GetAxis ("Vertical");
		h = Input.GetAxis ("Horizontal");
		rb.AddForce (tr.forward * ver * 80f);
		mouse = Input.GetAxis ("Mouse X");
		Vector3 r = new Vector3 (0, mouse, 0);
		tr.Rotate (r * 5f);
		f = Input.GetAxis ("Fire1");
		if (f > 0) {
			clone=Instantiate(obj, dulo.position,dulo.rotation);
			clone.AddForce (tr.forward * 5000f);

		}

		d = Input.GetAxis ("Fire2");


		if (d > 0) {
			zoomCam.enabled = true;
			myCam.enabled = false;

		} else {
			zoomCam.enabled = false;
			myCam.enabled = true;
		}

	}

	}
