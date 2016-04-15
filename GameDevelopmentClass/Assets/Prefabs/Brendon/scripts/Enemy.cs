using UnityEngine;
using System.Collections;
using System;

class Enemy : MonoBehaviour {

    public GameObject enemycube;

    public int health = 100;
   

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
        Destroy(enemycube);
        Destroy(this.gameObject);
        Destroy(this);
    }

    ////public Enemy(GameObject x)
    //{
    //    //cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    //    //Rigidbody rb =  cube.AddComponent<Rigidbody>();
    //    //cube.transform.position = new Vector3(-5f, 0.5f, -5f);
    //    //Debug.Log(cube.transform.position);
    //    Debug.Log("Constructor");

    //    enemycube = x;

    //    health = 100;
    //}

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject);
        GameObject player = GameObject.Find("Player");
        if (other.gameObject.Equals(player))
        {
            damage(50);
            Debug.Log("DMGCOLL: damage done = 50    current health = " + health );
        }
    }

   
}
