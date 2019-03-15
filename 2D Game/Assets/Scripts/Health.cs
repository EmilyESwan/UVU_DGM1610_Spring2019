using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public static int health;

	Text healthText;
	// Use this for initialization
	void Start () {
		healthText = GetComponent<Text>();

		health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0)
		// go to game over scene
		
		healthText.text = " " + health;
		
		}

	public static void AddPoints (int pointsToRemove){
		health -= pointsToRemove;
	}
		
	
}
