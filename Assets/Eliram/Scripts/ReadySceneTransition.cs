using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace saito
{
	public class ReadySceneTransition : MonoBehaviour
	{
		public int SpeedEasy, speedMedium, speedHard;
		public static int PlayerSpeed;
		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape)){
				Application.Quit ();
				Debug.Log (true);
			}
			if (Input.GetKeyDown("1"))
			{
				PlayerSpeed = SpeedEasy;
				SceneManager.LoadScene("Ready");

				//SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
			}
			if (Input.GetKeyDown("2"))
			{
				PlayerSpeed = speedMedium;
				SceneManager.LoadScene("Ready");

				//SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
			}
			if (Input.GetKeyDown("3"))
			{
				PlayerSpeed = speedHard;
				SceneManager.LoadScene("Ready");

				//SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
			}
		}
	}
}