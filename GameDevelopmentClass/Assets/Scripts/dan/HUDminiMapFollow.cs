using UnityEngine;
using System.Collections;

public class HUDminiMapFollow : MonoBehaviour {
    private Transform miniMap;
	private Transform Target;
    public string minimapName = "minimap";  //only for consistenct for saving to playerpref
    void Start()
    {
        miniMap = GameObject.Find("MiniMap").transform;
        Target = GameObject.FindGameObjectWithTag("Player").transform; //get transform method of player, so that the minimap can follow 
        //Target = Camera.main.transform;
        enableMiniMap();
    }
    //Late update is handled after normal update
    void LateUpdate()
    {
        
        transform.position = new Vector3(Target.position.x, transform.position.y, Target.position.z);
        //transform.rotation = new Quaternion(0.0f, Target.rotation.y, 0.0f, 0.0f);
        miniMap.rotation = Quaternion.Euler(90f, Target.rotation.eulerAngles.y, 0.0f);
   
       // Debug.Log(Target.transform.rotation.eulerAngles.y);
    }

    public void enableMiniMap()  // checks the playerPrefs and sets the minimap active or inactive.
    {
        if (PlayerPrefs.GetInt(minimapName) == 1)
        {
            Debug.Log("if minimap value playerpref: = true");
            gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("if minimap value playerpref: = false");
            gameObject.SetActive(false);
         
        }

    }
}
