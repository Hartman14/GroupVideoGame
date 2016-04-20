using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnEnemy : MonoBehaviour {

    //add more for increased enemy options
    public GameObject E1;

    //change value for avalible here = true and unavalible = false
    //
    public bool E1_Avalible;
    public bool E2_Avalible;

    int RandomSpawn;

    public float NumberOfMobs = 1;

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        List<Vector3> spawnList = new List<Vector3>();
            spawnList = EnemyPosition.getSpawns();

        foreach (Vector3 myVec in spawnList)
        {
            RandomizeSpawn(myVec);
        }

        Destroy(this.gameObject);
    }
    
    void RandomizeSpawn(Vector3 inputVec)
    {
         RandomSpawn = (int)Random.Range(1f, NumberOfMobs);

         if ((RandomSpawn == 1) && (E1_Avalible))
         {
            Spawn(E1, inputVec);
         }

         else
         {
            GameObject Enemy = (GameObject)Instantiate(E1, inputVec, Quaternion.identity);
         }
        
    }
    
    void Spawn(GameObject mob, Vector3 locVec)
    {
        GameObject Enemy = (GameObject)Instantiate(mob, locVec, Quaternion.identity);
    }
}
