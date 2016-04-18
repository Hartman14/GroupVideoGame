using UnityEngine;
using System.Collections;

public class OutOfBounds : MonoBehaviour {

    public GameObject Ranger;

    // Use this for initialization
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject == Ranger)
        {
            Destroy(other.gameObject);
        }
        
    }
}
