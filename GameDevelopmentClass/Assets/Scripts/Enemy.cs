using UnityEngine;
using System.Collections;
using System;

class Enemy : MonoBehaviour {

    

    public int health = 100;
   

    void Update()
    {

    }

    public void damage(int x)
    {
        health -= x;
        if (health <= 0)
        {
            death();
        }
    }

    public void death()
    {
        Debug.Log("death triggered");
        Destroy(this.gameObject);
        Destroy(this);
    }

    
   
}
