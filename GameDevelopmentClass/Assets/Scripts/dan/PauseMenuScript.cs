﻿
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PauseMenuScript : MonoBehaviour {

	public bool MenuShowing = false;
	public bool pauseGame = false;
	public GameObject pauseGroup;
	public Canvas pauseMenu; //quit menu canvas
	public Button quitGameButton;
	public Button ResumeButton;
	public Button NextLevelGameButton;
	public Button RestartLevelButton;
    // Use this for initialization

    public Text pauseMenuText;
	void Start () {
	pauseGame = false;


	
	}
	
	void OnApplicationPause(bool pauseStatus){
		pauseGame = pauseStatus;
	}
			
	// Update is called once per frame
	void Update () {

        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().IsDead())
        {
            
            showDeathMenu(); 
        }

        else {
            if (Input.GetKeyDown("p") || Input.GetKeyUp("escape"))
            {
                //print("test");
                pauseMenuText.text = "Paused";
                if (true)
                {
                    pauseGame = !pauseGame;
                }
                if (pauseGame == true)
                {
                   
                    showPauseMenu1();
                }
                else {
                    
                    resume();
                }
            }
            if (!pauseGame)
            {
                resume();
            }
        }
	}//end of update



	public void showPauseMenu1(){
		Time.timeScale = 0;
		MenuShowing = true;
		pauseMenu.enabled = true;
		//print ("pausegametrue");
	}

	public void resume(){
		Time.timeScale = 1;
		MenuShowing = false;
		pauseMenu.enabled = false;
		pauseGame = false;
		//print ("pausegame False");
	}

	public void restartLevel(){
		SceneManager.LoadScene (gameObject.scene.name);
	}

	 public void quitGame(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void NextLevelButton(){
        int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextLevel);
      //  print("next level " +nextLevel);


    }

    public void showDeathMenu()
    {

        pauseMenuText.text = "Died, try again";
        NextLevelGameButton.enabled = false;
        MenuShowing = true;
        pauseMenu.enabled = true;
        //print ("Yup you Dead bro, better luck next time"); //yours truely, Jordan
    }

    public void showPassLevelScreen()
    {
        pauseMenuText.text = "Passed Level";
        NextLevelGameButton.enabled = true;
        MenuShowing = true;
        pauseMenu.enabled = true;
    }
}
