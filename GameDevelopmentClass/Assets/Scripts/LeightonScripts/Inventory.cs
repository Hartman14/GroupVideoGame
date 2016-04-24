﻿using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
    private static int MAX_HEALTH = 100;

    private int health = 72;
    private int score = 0;

    [Range(0,100)] private int armor;

    private GameObject currentWeapon;
    private GameObject[] weapons;
    
   [Range(0,100)] private int arrows;
    

	// Use this for initialization
	void Start () {
	     
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void ChangeHealth(int delta)
    {
        health += delta;
        if(health <= 0)
        {
            this.Die();
        }
        else if(health > MAX_HEALTH)
        {
            health = MAX_HEALTH;
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    public void AddScore(int score)
    {
        if (score > 0)
        {
            this.score += score;
        }
    }

    public void AddArmor(int armor)
    {
        this.armor += armor;
    }

    public void ChangeWeapon(int index)
    {
        currentWeapon = weapons[index];
        //this.EquipWeapon...
    }

    public int GetHealth()   //current health
    {
        return health;
    }

    public int GetScore()
    {
        return score;
    }

    public int GetArmor()
    {
        return armor;

    }

    public int GetMaxHealth()  //get max full health
    {
        return MAX_HEALTH;
    }
    



    
}
