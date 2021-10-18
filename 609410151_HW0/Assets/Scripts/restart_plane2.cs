using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart_plane2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	public void OnCollisionEnter(Collision collision)
	{
		Application.LoadLevel (1);
	}

	// Update is called once per frame
	void Update () {

	}
}
