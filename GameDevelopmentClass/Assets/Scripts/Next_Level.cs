using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Next_Level : MonoBehaviour {

    public string nextLevel;

    public void ChangeLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
