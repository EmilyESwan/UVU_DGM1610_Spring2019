using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifStatements : MonoBehaviour {

	public string feeling;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	if(feeling == "Happy"){
		print("I'm glad you're happy!");
	}
	else if(feeling == "Sad"){
		print("I'm sorry you're feeling sad.");
	}
	else if(feeling == "Angry" || feeling == "Mad"){
		print("I'm sorry you feel so angry.");
	}
	else if(feeling == "Hungry" || feeling == "Hangry"){
		print("You should eat something!");
	}
	else if(feeling == "Scared" || feeling =="Afraid"){
		print("Don't be afraid. I won't hurt you!");
	}
	else{
		print("I don't know that feeling.");
	}
	}
}
