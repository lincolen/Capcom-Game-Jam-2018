using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Result
{
    Clear,
    GameOver
}

public class GameManager : MonoBehaviour {

    private static List<string> listOfItems;
    private static Result res;

    void Start()
    {
        listOfItems = new List<string>();
    }

    public static void AddItem(string tag)
    {
        // Debug.Log(tag);
        listOfItems.Add(tag);
        // Debug.Log(listOfItems[0]);
    }

    public static List<string> GetItems()
    {
        return listOfItems;
    }

    public static void SetResult(Result argRes)
    {
        res = argRes;
    }

    public static Result GetResult()
    {
        return res;
    }
}
