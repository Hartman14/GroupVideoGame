using UnityEngine;
using System.Collections;

public class HUDminiMapFollow : MonoBehaviour {

	private Transform Target;
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").transform; //get transform method of player, so that the minimap can follow 
        //Target = Camera.main.transform;
    }
    //Late update is handled after normal update
    void LateUpdate()
    {
        transform.position = new Vector3(Target.position.x, transform.position.y, Target.position.z);
        //transform.rotation = new Quaternion(0.0f, Target.rotation.y, 0.0f, 0.0f);
     
    }
}
