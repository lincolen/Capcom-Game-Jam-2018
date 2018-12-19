using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useItemGeneral : MonoBehaviour {
	public GameObject item1,item2,item3;
	public Transform spawnPoint;
	private List<string> items;

	public void UseItem1 () {

		item2.transform.position = (new Vector3(0.0f,-10.0f,0.0f));
		item3.transform.position = (new Vector3(0.0f,-10.0f,0.0f));

		item1.transform.position = spawnPoint.position;

		//GameObject useItem = Instantiate (item1, spawnPoint.position, Quaternion.identity) as GameObject;
		//Item1.transform.parent = transform;

	}

	public void UseItem2 () {

		item1.transform.position = (new Vector3(0.0f,-10.0f,0.0f));
		item3.transform.position = (new Vector3(0.0f,-10.0f,0.0f));

		item2.transform.position = spawnPoint.position;

		//Item1.transform.parent = transform;

	}

	public void UseItem3 () {
		item1.transform.position = (new Vector3(0.0f,-10.0f,0.0f));
		item2.transform.position = (new Vector3(0.0f,-10.0f,0.0f));

		item3.transform.position = spawnPoint.position;

		//Item1.transform.parent = transform;

	}
	// Use this for initialization
	void Start () {
		items = GameManager.GetItems();
		item1 = GameObject.FindGameObjectWithTag (items [0]);
		item2 = GameObject.FindGameObjectWithTag (items [1]);
		item3 = GameObject.FindGameObjectWithTag (items [2]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
