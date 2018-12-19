using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public void Event()
    {
        List<string> items = GameManager.GetItems();
        GameManager.SetResult(Result.GameOver);
        Debug.Log(items[0]);
    }
}
