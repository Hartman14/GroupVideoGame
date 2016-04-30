/*Daniel Anderson
 * apr 8, 2016 12:30a
 * modified apr 28
 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public string firstScene = "testscene";
	public Canvas quitMenu; //quit menu canvas
	//public Button newGameButton;  //newgame button 
	public Button loadGameButton;//loadgame button
	public Button quitGameButton;//loadgame button 
	public Button OptionsButton;//loadgame button 
	public Canvas optionsView;  //canvas for options view
	public Canvas loadGame;   //canvas for loadgame view
	public Canvas startMenu; //canvas for the main startmenu
	public Dropdown loadGameDropDownMenu;
    public Button OptionsSaveButton;

	//level names for load screen, will be changed for name of saved games
	public string[] levelNames = {"Main menu",
								  "Level1","Level2","Level3","Level4",
                                    };

	public string[] savedGames;




	// Use this for initialization
	void Start () {
        //PlayerPrefs.DeleteAll();  //clear all player preferences ie cookies
		//firstScene = "testscene";
		HideMenus ();

		//quitMenu = quitMenu.GetComponent<Canvas> ();
		//newGameButton = newGameButton.GetComponent<Button> ();
		//loadGameButton = loadGameButton.GetComponent<Button> ();
		//optionsView = optionsView.GetComponent<Canvas> ();
		//loadGame = loadGame.GetComponent<Canvas> ();
		//startMenu = startMenu.GetComponent<Canvas> ();


	}
	//this method hids all menus, except the start menu.  used to ensure that all extra menus are hidden when the game is started.
	//this is called in the start() method.
	public void HideMenus(){
		quitMenu.enabled = false;
		optionsView.enabled = false;
		loadGame.enabled = false;
		startMenu.enabled = true;

	}

	public void openStartMenu(){
		HideMenus ();
	}



	// this will open the quit menu to confirm the player would like to quit the game
	//this method hides the other views and and makes the quitmenu visible
	public void QuitPressed(){
		
		quitMenu.enabled = true;
		optionsView.enabled = false;
		loadGame.enabled = false;

	}
	public void loadSelectedButtonPressed(){
		if (loadGameDropDownMenu.value != 0) {
			SceneManager.LoadScene (loadGameDropDownMenu.value);
		}
		//print (loadGameDropDownMenu.value);
	}

	//the load button is pressed, this will ensure all other menus are disabled, and open the load menu.
	public void LoadPressed(){
		loadGameDropDownMenu.ClearOptions ();

		for (int i = 0; i < levelNames.Length; i++) {
			loadGameDropDownMenu.options.Add (new Dropdown.OptionData ( levelNames[i] ) );
		}
			quitMenu.enabled = false;
		optionsView.enabled = false;
		loadGame.enabled = true;

	

	}
	//this will exit a menu, and return to the startmenu
	public void NoPress(){
		
		quitMenu.enabled = false;
		optionsView.enabled = false;
		loadGame.enabled = false;

	}
	//this will display the options menu
	public void optionsPressed(){
		
		quitMenu.enabled = false;
		optionsView.enabled = true;
		loadGame.enabled = false;

	}
	//called by the new game button, this will start the first level selected
	public void StartLevel(){
		SceneManager.LoadScene (1);  // load the scene

	}
	//this method will quit the game
	public void ExitGame(){
		Application.Quit ();


	}
	// Update is called once per frame


    void optionsSavebuttonPressed()
    {
        print("saveButton");
    }


}
