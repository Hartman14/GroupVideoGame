using UnityEngine;
using System.Collections;

public class Gold_Pickup : MonoBehaviour {

  
    private int deltaScore = 50;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Player collided with Collectable: " + this.name + "!");
            //Put Pickup Code here
            var playerInventory = collision.gameObject.GetComponent<Inventory>();
            playerInventory.AddScore(deltaScore);
            Debug.Log("Player Score now = " + playerInventory.GetScore());
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
