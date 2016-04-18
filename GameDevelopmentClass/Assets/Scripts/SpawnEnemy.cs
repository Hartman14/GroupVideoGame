using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnEnemy : MonoBehaviour {

    public GameObject E1;
    
    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        List<Vector3> spawnList = new List<Vector3>();
            spawnList = EnemyPosition.getSpawns();

        foreach (Vector3 myVec in spawnList)
        {
            
            GameObject Enemy = (GameObject)Instantiate(E1, myVec, Quaternion.identity); ;
        }

        Destroy(this.gameObject);
    }
    
}
