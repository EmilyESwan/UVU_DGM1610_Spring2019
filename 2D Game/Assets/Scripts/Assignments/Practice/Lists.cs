using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour {

	public List<string> groceries = new List<string> ();

	// Use this for initialization
	void Start () {
		groceries.Add("Milk");
		groceries.Add("Eggs");
		groceries.Add("Candy");
		groceries.Add("Toilet Paper");
		groceries.Add("Potatoes");
		groceries.Add("Cheese");
		groceries.Add("Lettuce");
		groceries.Remove("Candy");
		groceries.Remove("Potatoes");

		print(groceries[6]); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
