using UnityEngine;
using System.Collections;

public class Armor_Pickup : MonoBehaviour {

    [Range(0, 100)]
    private int deltaArmor = 1;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Player collided with Collectable: " + this.name + "!");
            //Put Pickup Code here
            var playerInventory = collision.gameObject.GetComponent<Inventory>();
            playerInventory.AddArmor(deltaArmor);
            Debug.Log("Player Armor now = " + playerInventory.GetArmor());
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
