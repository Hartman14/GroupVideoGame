using UnityEngine;
using System.Collections;

public class ListAdder : MonoBehaviour {
    public int spawnpoint_Num;

    

    void Update()
    {
        doAction();
    }

    private void doAction()
    {
        Vector3 currentPos = transform.position;
        EnemyPosition.listAdd(currentPos, spawnpoint_Num);
        Destroy(this.gameObject);
    }
	

}
