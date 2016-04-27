using UnityEngine;
using System.Collections;

public class PickupKey : MonoBehaviour
{
    public AudioClip keyGrab;

    private GameObject player;
    private Inventory playerInventory;

    private GameObject door1;
    private GameObject door2;

    void awake()
    {
        player = GameObject.FindGameObjectWithTag(Tags.player);
        playerInventory = player.GetComponent<Inventory>();
        
    }

    void OnTriggerEnter(Collider other)
    {
        door1 = GameObject.Find("Door_B (1)");
        door2 = GameObject.Find("Door");

        // If the colliding gameobject is the player
        if (other.gameObject == player)
        {
            // play the clip at the position of the key
            AudioSource.PlayClipAtPoint(keyGrab, transform.position);

            // the player has a key
            playerInventory.hasKey = true;

            // and destroy this gameobject.
            Destroy(this.gameObject);
        }
    }
}
