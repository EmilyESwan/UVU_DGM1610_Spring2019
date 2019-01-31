using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {
	// Variables
	public static int Number;
	public float speed;
	public string Name;

	// Use this for initialization
	void Start () {
		Number = 10;
		speed = 0.1918f;
		Name = "Bob";

		print (Name +" is "+Number+" years old!"+ speed); 

	}
	/*Multi
	Line 
	Comment */

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Number,speed,0);
	}
}
