using UnityEngine;
using System.Collections;


public class ManageKeys : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {

        int keepkey = Random.Range(0, 4);
        
        if(keepkey != 0)
        {
            Destroy(GameObject.Find("Dungeon_Key_Set"));
        }
        if (keepkey != 1)
        {
            Destroy(GameObject.Find("Dungeon_Key_Set(1)"));
        }
        if (keepkey != 2)
        {
            Destroy(GameObject.Find("Dungeon_Key_Set(2)"));
        }
        if (keepkey != 3)
        {
            Destroy(GameObject.Find("Dungeon_Key_Set(3)"));
        }

    }
}
