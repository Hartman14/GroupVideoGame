using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnEnemy : MonoBehaviour {

    
    
    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        List<Vector3> spawnList = new List<Vector3>();
            spawnList = EnemyPosition.getSpawns();

        foreach (Vector3 myVec in spawnList)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.localScale += new Vector3(2f, 2f, 2f);
            cube.transform.position = myVec;
            var myScript = cube.AddComponent<Enemy>();
            cube.AddComponent<Rigidbody>();
        }

        Destroy(this.gameObject);
    }
    
}
