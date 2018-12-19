using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private float readyTimer;
    public Text lastSeconds;

	// Use this for initialization
	void Start () {
        readyTimer = 0;
        lastSeconds.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        readyTimer += Time.deltaTime;

        if (readyTimer < 1)
        {
            lastSeconds.text = "準備してね！";
        }
        else
        {
            lastSeconds.text = "残り時間\n" + (30+1 - (int)readyTimer).ToString();
        }

        // Debug.Log(readyTimer);
        if(readyTimer >= 30+1)
        {
            SceneManager.LoadScene("Stage");
        }
	}
}
