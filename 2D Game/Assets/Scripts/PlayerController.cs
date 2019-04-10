using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//Player movement variables
	public float moveSpeed;
	public float jumpHeight;
	//Player grounded variables
	private bool grounded;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;

	void Start () {
	
	}

	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	
	}
	void Update () {
		//Moves player left and right
		if(Input.GetKey(KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
		else if(Input.GetKey(KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

		//Makes player jump
		if(Input.GetKeyDown(KeyCode.W) && grounded){
			Jump();
		}

		//Player Flip
		if(GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(182f,177f,1f);
		else if (GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(-182f,177f,1f);


	
	}

	void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
	}

}
