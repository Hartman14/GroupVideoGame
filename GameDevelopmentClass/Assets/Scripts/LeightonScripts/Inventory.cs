using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{

    public bool hasKey;

    private static int MAX_HEALTH = 100;
    private static int MAX_ARMOR = 100;
    private int health = 72;
    private int score = 0;

    public int startingHealth = 100;
    public int startingArmor = 100;

    [Range(0, 100)]
    private int armor;

    public GameObject weapons;

    bool Dead = false;

    //------------------------------------------------------------------------------------------------------------------------------------------------------------

    // Use this for initialization
    void Start()
    {
        MAX_HEALTH = startingHealth;
        MAX_ARMOR = 100;
        health = startingHealth;
        armor = startingArmor;
    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
            health = 0;
            Die();
        }

    }

    public void ChangeHealth(int delta)
    {
        health += delta;

        if (health > MAX_HEALTH)
        {
            health = MAX_HEALTH;
        }
    }

    private void Die()
    {
        Dead = true;
        gameObject.GetComponent<RotateWeapons>().StopAllCoroutines();
        Destroy(weapons);
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
    public int GetMaxArmor()  //get max full Armor
    {
        return MAX_ARMOR;
    }

    public bool IsDead()
    {
        return Dead;
    }

    void TakeDamage(int incoming)
    {
        health -= incoming;
    }

    void OnTriggerEnter(Collider ouch)
    {
        if (ouch.gameObject.tag == "Dagger")
        {
            TakeDamage((int)(ouch.GetComponent<SwordDamage>().Damage * ((float)10/armor)));
        }

        else if (ouch.gameObject.tag == "Key")
        {
            ouch.gameObject.SetActive(false);

            GameObject target = GameObject.Find("Door_B (1)");

            target.SetActive(false);
        }

        else if(ouch.gameObject.tag == "Door")
        {
            ouch.gameObject.SetActive(false);
        }

    }
}
