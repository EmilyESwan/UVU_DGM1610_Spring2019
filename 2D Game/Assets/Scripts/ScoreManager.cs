using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public static int score;

	Text scoreText;
	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text>();

		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (score < 0)
			score = 0;
		scoreText.text = " " + score;
	}

	public static void AddPoints (int pointsToAdd){
		score += pointsToAdd;
	}
}
