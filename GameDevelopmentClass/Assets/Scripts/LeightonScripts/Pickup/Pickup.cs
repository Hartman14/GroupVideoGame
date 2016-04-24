using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{
    public AudioClip keyGrab;

    public GameObject player;
    private Inventory playerInventory;

    void awake()
    {
        player = GameObject.FindGameObjectWithTag(Tags.player);
        playerInventory = player.GetComponent<Inventory>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            AudioSource.PlayClipAtPoint(keyGrab, transform.position);

            Inventory.hasKey = true;

            Destroy(gameObject);
        }
    }

}
