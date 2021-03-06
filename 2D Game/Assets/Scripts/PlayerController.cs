﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//Player movement variables
	public float moveSpeed;
	public float jumpHeight;
	private bool doubleJump;

	//Player grounded variables
	private bool grounded;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;

	//Non-Slide Player
	private float moveVelocity; 

	public Animator animator;
	void Start () {
		//Animator reset
		animator.SetBool("isWalking", false);
		animator.SetBool("isJumping", false);
	}

	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	
	}
	void Update () {
		
		//Double jump code
		if(grounded){
			doubleJump = false;
			animator.SetBool("isJumping",false);
		}

		if(Input.GetKeyDown (KeyCode.W) && !doubleJump && !grounded){
			Jump();
			doubleJump = true;
		}

		//Non-Slide Player
		moveVelocity = 0f;

		//Moves player left and right
		if(Input.GetKey(KeyCode.D)){
			// GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = moveSpeed;
			animator.SetBool("isWalking", true);
		}

		else if(Input.GetKeyUp (KeyCode.D)){
			animator.SetBool("isWalking", false);
		}
		
		if(Input.GetKey(KeyCode.A)){
			// GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = -moveSpeed;
			animator.SetBool("isWalking", true);
		}

		else if (Input.GetKeyUp(KeyCode.A)){
			animator.SetBool("isWalking", false);
		}

		GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

		//Makes player jump
		if(Input.GetKeyDown(KeyCode.W) && grounded){
			Jump();
			animator.SetBool("isJumping", true);
		}
		else if(Input.GetKeyUp(KeyCode.W)){
			animator.SetBool("isJumping", false);

		}

		//Player Flip
		if(GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(4f,4f,1f);

		else if (GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(-4f,4f,1f);



	
	}

	void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
	}

}
