using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class InGameMenu : MonoBehaviour {

	private bool pauseGame = false;
	private bool showPauseMenu = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown("p"))
			{
				pauseGame = !pauseGame;
				if (pauseGame == true) 
				{
					Time.timeScale = 0;
					pauseGame = true;
					//GameObject.Find ("Main Camera").GetComponent(MouseLook).enabled = false;
					showPauseMenu = true;
				} 
				else{
					Time.timeScale = 1;
					pauseGame = false;
					//GameObject.Find ("Main Camera").GetComponent(MouseLook).enabled = true;
					showPauseMenu = false;
				}

				if (showPauseMenu == true) {





				}
					
			}	
	}

}
