using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PauseMenuScript : MonoBehaviour {

	public bool pauseGame = false;
	public GameObject pauseGroup;
	public Canvas pauseMenu; //quit menu canvas
	public Button quitGameButton;
	public Button ResumeButton;
	public Button SaveGameButton;
	public Button RestartLevelButton;
	// Use this for initialization
	void Start () {



	
	}
	void onGUI(){
		if (pauseGame) {
			GUI.Label (new Rect (100, 100, 50, 30), "Game paused");
		}
	}
	void OnApplicationPause(bool pauseStatus){
		pauseGame = pauseStatus;
	}
			
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("p")) {
			print ("test");
			pauseGame = !pauseGame;

			if (pauseGame == true) {	
				//GameObject.Find ("Main Camera").GetComponent(MouseLook).enabled = false;	
				showPauseMenu1 ();
			} else {
				//GameObject.Find ("Main Camera").GetComponent(MouseLook).enabled = true;
				resume ();
			}
		}
		if (!pauseGame) {
			resume ();
		}
	}//end of update



	public void showPauseMenu1(){
		Time.timeScale = 0;

		pauseMenu.enabled = true;
		//print ("pausegametrue");
	}

	public void resume(){
		Time.timeScale = 1;
		pauseMenu.enabled = false;
		//print ("pausegame False");
	}

	public void restartLevel(){
		SceneManager.LoadScene (gameObject.scene.name);
	}

	 public void quitGame(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void saveGame(){

	}
}
