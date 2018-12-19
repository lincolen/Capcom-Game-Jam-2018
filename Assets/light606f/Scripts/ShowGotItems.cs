using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowGotItems : MonoBehaviour {

    public Text textGotItems;
    private List<string> items;

	// Update is called once per frame
	void Update () {
        SetText();
	}

    void SetText()
    {
        textGotItems.text = "準備したアイテム : ";
        items = GameManager.GetItems();
        // Debug.Log(items.Count);
        for ( int i = 0; i < items.Count; i++)
        {
            textGotItems.text += "\n" + items[i];
        }
        textGotItems.text += "\n残り準備可能数 : " + (5 - items.Count).ToString();
    }
}
