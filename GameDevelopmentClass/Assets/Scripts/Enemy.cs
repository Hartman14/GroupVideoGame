using UnityEngine;
using System.Collections;
using System;

class Enemy : MonoBehaviour {


    public GameObject AD;
    public GameObject SD;


    public int health = 100;
   

    void Update()
    {
        if (health <= 0)
        {
            death();
        }
    }

    public void damage(int x)
    {
        health -= x;
        
    }

    public void death()
    {
        Debug.Log("death triggered");
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Arrower")
        {
            damage((int)AD.GetComponent<ArrowDamage>().Damage);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Sword")
        {
            damage((int)SD.GetComponent<MeleeWeapon>().Damage);
        }
    }

}
