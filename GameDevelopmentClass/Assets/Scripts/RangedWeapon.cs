﻿using UnityEngine;
using System.Collections;

public class RangedWeapon : MonoBehaviour {

    public GameObject Bow;
    public GameObject Arrow;
    public GameObject ShotSpawn;
    GameObject projectile;

    public Animation BowAttack;

    public float Damage;
    public float ArrowSpeed;

    bool InAction = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKeyDown(KeyCode.Mouse0) && !InAction)
        {
            Attack();
        }

	}

    void Attack()
    {
        InAction = true;
        GetComponent<Animation>().CrossFade(BowAttack.name);
        if (!GetComponent<Animation>().isPlaying)
        {
            FireProjectile();
            InAction = false;
        }
    }

    void FireProjectile()
    {
        projectile = Arrow;
        GameObject ShootProjectile = (GameObject)Instantiate(Arrow, ShotSpawn.transform.position, Quaternion.identity);
        ShootProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * ArrowSpeed * 200);
    }

}
