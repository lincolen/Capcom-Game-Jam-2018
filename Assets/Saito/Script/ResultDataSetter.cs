using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultDataSetter : MonoBehaviour {

    Result _Result;

    public GameObject TitleLabel;

	// Use this for initialization
	void Start () {
        _Result = GameManager.GetResult();

        var titleLabelText = TitleLabel.GetComponent<Text>();
        titleLabelText.text = _Result.ToString();
    }
	
	// Update is called once per frame
	void Update () {

	}
}
