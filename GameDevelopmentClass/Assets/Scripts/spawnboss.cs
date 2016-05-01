using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawnboss : MonoBehaviour
{
    public int spawnNum;
    //add more for increased enemy options
    public GameObject E1;


    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        List<Vector3> spawnList = new List<Vector3>();
        spawnList  = EnemyPosition.getSpawns_boss(spawnNum);

        foreach (Vector3 myVec in spawnList)
        {
            Spawn(E1, myVec);
        }

        Destroy(this.gameObject);
    }

   

    void Spawn(GameObject mob, Vector3 locVec)
    {
        GameObject boss = (GameObject)Instantiate(mob, locVec, Quaternion.identity);
    }
}
