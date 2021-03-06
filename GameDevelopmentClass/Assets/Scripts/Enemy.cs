﻿using UnityEngine;
using System.Collections;
using System;

class Enemy : MonoBehaviour {
    //franklin
    public AudioClip hurtclip;
    private AudioSource hurtSound;

    public AudioClip deathscream;
    private AudioSource deathsound;

    public AnimationClip Death;

    public GameObject Dagger;

    public int health = 100;
   
    int count = 0;

    bool Died = false;

    void Start()
    {
        deathsound = GetComponent<AudioSource>();
        hurtSound = GetComponent<AudioSource>();
        
        
    }
    void Update()
    {
        if (health <= 0)
        {
            try
            {
                if (!deathsound.isPlaying && Time.time >= 1)
                {

                    deathsound.PlayOneShot(deathscream, 1f);
                }
            }
            catch { }
            if (!GetComponent<Animation>().IsPlaying(Death.name))
            {
                if (!Died)
                {
                    DestroyWeapons();
                    GetComponent<Animation>().CrossFade(Death.name);
                    Died = true;
                }
                else if (Died)
                {
                    death();
                }
            }
        }
    }

    public void damage(int x)
    {
        health -= x;
        
    }

    public void death()
    {
        Debug.Log("death triggered");
        if(this.name == "BossSkeletonDark(Clone)")
        {
            Debug.Log("boss killed");
            GameObject target = GameObject.Find("finaltriggerObj");
            target.transform.Translate(new Vector3(0.0f, 0.0f, 20f));
            target.SetActive(true);
        }
        Debug.Log(this.name);
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
            hurtSound.PlayOneShot(hurtclip, 1.5f);
            damage((int)other.GetComponent<ArrowDamage>().Damage);
            Destroy(other.gameObject);
            Debug.Log("arrow hit enemy");
        }

        if (other.gameObject.tag == "Sword")
        {
            try {
                hurtSound.PlayOneShot(hurtclip, 1.5f);
            }
            catch { }
            damage((int)other.GetComponent<SwordDamage>().Damage);
            Debug.Log("sword hit enemy");
        }

        else
        {

        }
    }

    void DestroyWeapons()
    {
        Destroy(Dagger);
    }

    public bool getDead()
    {
        return Died;
    }

}
