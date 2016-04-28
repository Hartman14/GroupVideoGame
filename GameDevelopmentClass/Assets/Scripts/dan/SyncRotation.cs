using UnityEngine;
using System.Collections;

public class SyncRotation : MonoBehaviour {
   private GameObject syncTo;
    public Camera syncFrom;
    // Use this for initialization
	void Start () {
        syncTo = gameObject;
        syncFrom = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
        syncTo.transform.rotation = syncFrom.transform.rotation;
	}
}
