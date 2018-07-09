using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class PauseGame : MonoBehaviour
{

    public GameObject pauseMenuUI;
    public GameObject uiPanel;
	public static bool gameIsPaused = false;

	// Update is called once per frame
	void Update ()
	{	
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (gameIsPaused) {
				Resume ();
			} else {
				Pause ();
			}
		}
	}

	public void Resume ()
	{
		pauseMenuUI.SetActive (false);
        uiPanel.SetActive (true);
		Time.timeScale = 1;
		gameIsPaused = false;
	}

	public void Pause ()
	{
		pauseMenuUI.SetActive (true);
        uiPanel.SetActive (false);
		Time.timeScale = 0;
		gameIsPaused = true;
	}


		
}
