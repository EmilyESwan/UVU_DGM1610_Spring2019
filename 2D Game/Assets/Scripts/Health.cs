using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public static int health;

	Text healthText;

	void Start () {
		healthText = GetComponent<Text>();

		health = 100;
	}
	
	void Update () {
		if (health < 0)
			health = 0;
	
		healthText.text = " " + health;
		
	}
		
	public static void AddPoints (int pointsToAdd){
		health += pointsToAdd;
	}
}
