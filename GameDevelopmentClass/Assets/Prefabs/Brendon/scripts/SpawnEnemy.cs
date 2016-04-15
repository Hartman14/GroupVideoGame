using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnEnemy : MonoBehaviour {

    GameObject cube;
    int xxxx = 0;
    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        List<Vector3> spawnList = new List<Vector3>();
            spawnList = EnemyPosition.getSpawns();

        foreach (Vector3 myVec in spawnList)
        {
            cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = myVec;
            var myScript = cube.AddComponent<Enemy>();
            cube.AddComponent<Rigidbody>();
        }
        //xxxx += 2;
        //cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ////ScriptableObject enemy = ScriptableObject.CreateInstance("Enemy");
        //Debug.Log("OnTriggerEnter");
        //cube.transform.position = new Vector3(-5f+xxxx, 0.5f, -5f);

        //var myScript = cube.AddComponent<Enemy>();
        //Debug.Log("Enemy Added");
        //cube.AddComponent<Rigidbody>();

        //myScript.enemycube = cube;

        Destroy(this.gameObject);
    }

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
