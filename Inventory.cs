using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
    private static double MAX_HEATLH = 100;

    private double health = 50;
    private int score = 0;

    [Range(0,100)] private double armor;

    private GameObject currentWeapon;
    private GameObject[] weapons;
    
   [Range(0,100)] private int arrows;
    

	// Use this for initialization
	void Start () {
	     
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void ChangeHealth(double delta)
    {
        health += delta;
        if(health <= 0)
        {
            this.Die();
        }
        else if(health > MAX_HEATLH)
        {
            health = MAX_HEATLH;
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

    public void AddArmor(double armor)
    {
        this.armor += armor;
    }

    public void ChangeWeapon(int index)
    {
        currentWeapon = weapons[index];
        //this.EquipWeapon...
    }

    public double GetHealth()
    {
        return health;
    }

    public int GetScore()
    {
        return score;
    }

    public double GetArmor()
    {
        return armor;
    }

    



    
}
