using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysListsDicts : MonoBehaviour {


	public string client1 = "Greg";
	public string client2 = "Mary";
	public string client3 = "Louis";
	public string client4 = "Jake";
	public string client5 = "Sarah";

	// Array Example
	public string[] clientList = new string[]{"Greg","Mary","Louis","Jake","Sarah"};
	
	// List Example
	public List<string> santasList = new List<string>();
	
	// ArrayList Example
	public ArrayList inventory = new ArrayList();
	
	// Use this for initialization
	void Start () {
		santasList.Add("John");	
		santasList.Add("Mark");
		santasList.Add("Lily");
		santasList.Add("Carrie");	
		santasList.Add("Alice");	
		santasList.Remove("John");

		print(clientList[2]);

		print(santasList[3]);

		inventory.Add(10);
		inventory.Add("Bob");
		inventory.Add(true);
		inventory.Add(2.343);

		print(inventory[1]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
