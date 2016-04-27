using UnityEngine;
using System.Collections;

public class DestructableObject : MonoBehaviour
{

    int hitcount;
    int hitsToKill;
    // Use this for initialization
    void Start()
    {
        hitcount = 0;
        hitsToKill = 2;
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sword")
        {
            hitcount++;
        }
        if (hitcount == hitsToKill)
        {
            death();
        }
    }

    void death()
    {
        Destroy(gameObject);
    }
}
