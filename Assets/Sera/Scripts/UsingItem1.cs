using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingItem1 : MonoBehaviour {
	public GameObject Item1;
	public Transform spawnPoint;

	public void UseItem1 () {
		GameObject useItem = Instantiate (Item1, spawnPoint.position, Quaternion.identity) as GameObject;
		//Item1.transform.parent = transform;
	
	}
	

}
