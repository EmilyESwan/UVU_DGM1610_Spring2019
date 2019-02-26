using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_Statements : MonoBehaviour {

	public string stopLight;
	public bool isUtahn = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(stopLight == "Red"){
			
			if(isUtahn){
			print("Stop! The Light is Red!");	
			}
			
			else{
				print("Thank you for preparing to stop");
			}
		}
		else if(stopLight == "Yellow"){
			
			if(isUtahn){
				print("Slow down!");	
			}
			else{
				print("Thank you for preparing to stop!");
			}
		}
		else if(stopLight == "Green"){
			
			if(isUtahn){
				print("You can go!");
			}
			else{
				print("Thank you for accelerating forward");
			}

		}
		else{
			print("Sorry, you're driving in Utah!");
		}
	}
}
