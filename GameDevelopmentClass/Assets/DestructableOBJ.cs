using UnityEngine;
using System.Collections;

public class DestructableOBJ : MonoBehaviour
{

    //this is an empty default constructor so we can use the enclosed "spawning" protical to create collectables
    public DestructableOBJ()
    {
    }

    public int hits_to_kill = 3;
    public GameObject healthPrefab;
    public GameObject poisonPreafab;
    public GameObject armourPrefab;
    public GameObject goldPrefab;

    GameObject spawnedItem;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sword")
        {
            damage();
            Debug.Log("sword hit destructable object");
        }
    }

    void damage()
    {
        hits_to_kill--;
        if (hits_to_kill <= 0)
        {
            death();
        }
    }

    void death()
    {
        spawnRandItem(this.transform.position);
        Destroy(gameObject);
    }

    public void spawnRandItem(Vector3 myVec)
    {
        int num = Random.Range(0, 4);
        spawnItem(num, myVec);
    }

    public void spawnItem(int num, Vector3 myVec)
    {
        if (num == 0)
        {
            spawnedItem = (GameObject)Instantiate(healthPrefab, myVec, new Quaternion(0, 0, 0, 0));
        }
        if (num == 1)
        {
            spawnedItem = (GameObject)Instantiate(poisonPreafab, myVec, new Quaternion(0, 0, 0, 0));
        }
        if (num == 2)
        {
            spawnedItem = (GameObject)Instantiate(armourPrefab, myVec, new Quaternion(0, 0, 0, 0));
        }
        if (num == 3)
        {
            spawnedItem = (GameObject)Instantiate(goldPrefab, myVec, new Quaternion(0, 0, 0, 0));
        }
    }

}
