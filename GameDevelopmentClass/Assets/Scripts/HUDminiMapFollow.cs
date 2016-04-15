using UnityEngine;
using System.Collections;

public class HUDminiMapFollow : MonoBehaviour {

	public Transform Target;

	// Use this for initialization
	void Start () {

	}
	
	//Late update is handled after normal update
	void LateUpdate () {
		transform.position = new Vector3 (Target.position.x, transform.position.y, Target.position.z);
	}
}
