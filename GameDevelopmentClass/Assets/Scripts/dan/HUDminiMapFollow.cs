using UnityEngine;
using System.Collections;

public class HUDminiMapFollow : MonoBehaviour {

	private Transform Target;
    void Start()
    {
        Target = Camera.main.transform;
    }
	//Late update is handled after normal update
	void LateUpdate () {
		transform.position = new Vector3 (Target.position.x, transform.position.y, Target.position.z);
	}
}
