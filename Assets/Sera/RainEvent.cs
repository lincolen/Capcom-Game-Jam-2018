using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RainEvent : MonoBehaviour {

	public Text safeText;

	// Use this for initialization
	void OnTriggerEnter (Collider col) {
		if(col.gameObject.tag == "Umbrella" || col.gameObject.tag == "Bag"){
			safeText.text = "Safe!";
		}
		else{
		//	LoadingNewScene();
		safeText.text = "Out!";
		//GameManager.SetResult(Result.GameOver);
		}
		
	}
	/* public void LoadingNewScene(){
		SceneManager.LoadScene("Result");
	}*/
			
	
	
}
