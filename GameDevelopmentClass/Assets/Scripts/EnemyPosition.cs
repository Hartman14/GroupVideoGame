using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class EnemyPosition : MonoBehaviour {

    static List<Vector3> enemypos = new List<Vector3>();
    
    public static void listAdd(Vector3 newVec)
    {
        enemypos.Add(newVec);
    }

    public static List<Vector3> getSpawns()
    {
        return enemypos;
    }
}
