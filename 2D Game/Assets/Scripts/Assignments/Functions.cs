using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {

	public string weather; 


	void Start(){
		Weather(weather);
	}

	void Weather(string weatherState){

		if(weatherState == "Sunny"){
			print("The sun is shining today!");
		}
		else if(weatherState == "Raining"){
			print("It is raining today!");
		}
		else if(weatherState == "Windy"){
			print("It is very windy today!");
		}
		else if(weatherState == "Snowing"){
			print("It is snowing today!");
		}
		else if(weatherState == "Foggy"){
			print("It is very foggy today!");
		}
		else if(weatherState == "Canadian"){
			print("Eh?");
		}
		else{
			print("I don't understand "+ weatherState);
		}

	}
}
