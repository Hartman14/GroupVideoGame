using UnityEngine;
using System.Collections;

public class HUDminiMapFollow : MonoBehaviour {
    private Transform miniMap;
	private Transform Target;
    void Start()
    {
        miniMap = GameObject.Find("MiniMap").transform;
        Target = GameObject.FindGameObjectWithTag("Player").transform; //get transform method of player, so that the minimap can follow 
        //Target = Camera.main.transform;
    }
    //Late update is handled after normal update
    void LateUpdate()
    {
        
        transform.position = new Vector3(Target.position.x, transform.position.y, Target.position.z);
        //transform.rotation = new Quaternion(0.0f, Target.rotation.y, 0.0f, 0.0f);
        miniMap.rotation = Quaternion.Euler(90f, Target.rotation.eulerAngles.y, 0.0f);
   
       // Debug.Log(Target.transform.rotation.eulerAngles.y);
    }
}
