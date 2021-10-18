using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart_plane : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	public void OnCollisionEnter(Collision collision)
	{
		Application.LoadLevel (0);
	}

	// Update is called once per frame
	void Update () {

	}
}
