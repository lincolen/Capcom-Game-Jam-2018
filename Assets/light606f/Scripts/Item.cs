using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour {

	public void AddThisItem()
    {
        GameManager.AddItem(transform.tag);
        // Debug.Log(transform.root.name);
        Destroy(transform.gameObject,0.3f);
    }
}
