using UnityEngine;
using System.Collections;

public class ListAdder : MonoBehaviour {

	// Use this for initialization
	void Start () {

    
	}

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
