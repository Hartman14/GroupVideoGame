using UnityEngine;
using System.Collections;

public class OutOfBounds : MonoBehaviour {

    

    // Use this for initialization
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Arrow")
        {
            Destroy(other.gameObject);
        }
        
    }
}
