using UnityEngine;
using System.Collections;

public class ListAdder_caster : MonoBehaviour {
    public int spawnpoint_Num;



    void Update()
    {
        doAction();
    }

    private void doAction()
    {
        Vector3 currentPos = transform.position;
        EnemyPosition.listAdd_caster(currentPos, spawnpoint_Num);
        Destroy(this.gameObject);
    }
}
