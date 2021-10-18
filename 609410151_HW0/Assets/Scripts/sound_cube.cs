using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_cube : MonoBehaviour {
	public AudioSource bells;
	// Use this for initialization
	void Start () {
		
	}

	public void OnCollisionEnter(Collision collision)
	{
		bells.Play ();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
