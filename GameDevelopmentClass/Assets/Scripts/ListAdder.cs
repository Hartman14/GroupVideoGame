using UnityEngine;
using System.Collections;

public class ListAdder : MonoBehaviour {

    void Update()
    {
        doAction();
    }

    private void doAction()
    {
        Vector3 currentPos = transform.position;
        EnemyPosition.listAdd(currentPos);
        Destroy(this.gameObject);
    }
	

}
