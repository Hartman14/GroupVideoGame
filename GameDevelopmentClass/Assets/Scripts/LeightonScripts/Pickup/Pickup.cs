using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Debug.Log("Player collided with Collectable: " + this.name + "!");
            //Put Pickup Code here
            
            //Pickup vanishes from the scene
            Destroy(gameObject);
        }
       

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}



}
