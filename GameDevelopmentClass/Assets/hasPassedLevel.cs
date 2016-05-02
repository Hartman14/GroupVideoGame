using UnityEngine;
using System.Collections;

public class hasPassedLevel : MonoBehaviour {
    public GameObject pause;
	// Use this for initialization
	void Start () {
        pause = GameObject.FindGameObjectWithTag("PauseMenu");
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            hasWonTrigger();
            Debug.Log("triggered");
        }
    }

    public void hasWonTrigger()
    {
        pause.GetComponentInChildren<PauseMenuScript>().showPassLevelScreen();
   
    }
	// Update is called once per frame
	void Update () {
	
	}
}
