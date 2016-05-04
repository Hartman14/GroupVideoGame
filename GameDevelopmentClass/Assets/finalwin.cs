//dan

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class finalwin : MonoBehaviour {
    

    // Use this for initialization
    void OnTriggerEnter(Collider ouch)
    {
        if (ouch.gameObject.tag == "Player")
        {
            int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextLevel);
        }
         
    }
}
