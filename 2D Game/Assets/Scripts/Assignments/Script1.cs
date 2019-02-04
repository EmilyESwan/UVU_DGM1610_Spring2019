using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour {

	public string favoriteFood; 


	void Start(){
		print("My favorite food is "+favoriteFood);
		Favorite(favoriteFood);
	}

	void Favorite(string favoriteFood){

		if(favoriteFood == "Ice cream"){
			print("Perfect for a hot day!");
		}
		else if(favoriteFood == "Pizza"){
			print("Mmmm, Pizza!");
		}
		else if(favoriteFood == "Jello"){
			print("Oooh, Jiggly!");
		}
		else if(favoriteFood == "the Souls of the Unborn"){
			print("Are you Satan?");
		}
		else if(favoriteFood == "Chicken Nuggets"){
			print("Yummy!");
		}
		else if(favoriteFood == "Beets"){
			print("What is wrong with you?!");
		}
		else 
			print("That's silly!");
	}
}
