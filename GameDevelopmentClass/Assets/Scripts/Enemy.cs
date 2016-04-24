﻿using UnityEngine;
using System.Collections;
using System;

class Enemy : MonoBehaviour {

    public AnimationClip Death;

    public int health = 100;
   
    int count = 0;

    void Update()
    {
        if (health <= 0)
        {
            GetComponent<Animation>().CrossFade(Death.name);
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

    void DeathAnimationCaller()
    {
        GetComponent<Animation>().CrossFade(Death.name);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Arrow")
        {
            damage((int)other.GetComponent<ArrowDamage>().Damage);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Sword")
        {
            damage((int)other.GetComponent<SwordDamage>().Damage);
        }

        else
        {

        }
    }

}
