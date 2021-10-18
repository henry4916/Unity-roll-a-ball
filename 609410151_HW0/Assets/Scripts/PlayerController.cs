using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections; 

public class PlayerController : MonoBehaviour
{
	public float speed;
	public Text countText;
	public Text winText;
	public AudioSource walk_sound;

	private Rigidbody rb;
	private int count;

	private MeshRenderer msRender;
	private float smooth = 0.5f;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		msRender = GetComponent<MeshRenderer>();
		count = 0;
		SetCountText();
		winText.text = "";
		//定時調用來變換成白色
		InvokeRepeating("color_change", 1, 2);
	}
	void Update()
	{
		//走路音效
		if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))  
		{  
			walk_sound.Play ();
		} 
		//走路音效
		if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))  
		{  
			walk_sound.Play ();
		}
		//走路音效
		if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {  
			walk_sound.Play ();
		}
		//走路音效
		if (Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {  
			walk_sound.Play ();
		}
		//重新開始場景轉換
		if (Input.GetKeyDown (KeyCode.R))  
		{
			if (Application.loadedLevel == 1) {
				Application.LoadLevel (1);
			}

			else if (Application.loadedLevel == 0) {
				Application.LoadLevel (0);
			}

		} 
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
	//定時調用來變換成白色
	void color_change()
	{
		msRender.material.color = Color.white;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			//變成紅色
			msRender.material.color = Color.red;
			count = count + 1;
			SetCountText ();
		}
			
	}

	//場景2的碰撞判斷
	public void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("pick up2")) {
			msRender.material.color = Color.red;
			count = count + 1;
			SetCountText ();
		}

	}



	void SetCountText()
	{
		countText.text = "count: " + count.ToString();

		if (count >= 12) {
			winText.text = "You Win!";
		}

	}
}
