using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovetoPlayer : MonoBehaviour {

	public float speed;
	public float distance;
	private Transform target;
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	// void OnTriggerEnter2D(Collider2D other){
	// 	if (other.tag =="PC"){
	// 		GetComponent<Rigidbody2D>().speed = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().speed.y);
	// 	}
	// }
	// Update is called once per frame
	void Update () {
		if(Vector2.Distance(transform.position, target.transform.position) < distance){
			transform.position = Vector2.MoveTowards(transform.position, target.position, speed);
		}
	}
}
