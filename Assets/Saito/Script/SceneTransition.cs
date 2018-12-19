using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace saito
{
    public class SceneTransition : MonoBehaviour
    {
        public string NextSceneName;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(NextSceneName);
                //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
            }
        }
    }
}