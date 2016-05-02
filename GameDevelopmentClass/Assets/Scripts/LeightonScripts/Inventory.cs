using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
    public AudioClip audioHurtPlayer;
    private AudioSource audioSrc;
    public bool hasKey;

    private static int MAX_HEALTH = 100;
    private static int MAX_ARMOR = 100;
    private int health = 72;
    private int score = 0;

    public int startingHealth = 100;
    public int startingArmor = 10;
    
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
        audioSrc = GetComponent<AudioSource>();

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

    public void AddScore(int incoming)
    {
        if (score > 0)
        {
            score += incoming;
        }
    }

    public void AddArmor(int incoming)
    {
        armor += incoming;
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
            TakeDamage((int)(ouch.gameObject.GetComponent<SwordDamage>().Damage * ((float)10/armor)));
            if (!audioSrc.isPlaying) // better but animation time and sound time differ
            {
                audioSrc.PlayOneShot(audioHurtPlayer, .2f);
            }

        }

        if (ouch.gameObject.tag == "Key")
        {
            ouch.gameObject.SetActive(false);

            GameObject target = GameObject.Find("Door_B (1)");

            target.SetActive(false);
        }

        if(ouch.gameObject.tag == "Door")
        {
            ouch.gameObject.SetActive(false);
        }

        if(ouch.gameObject.tag == "Fireball")
        {
            TakeDamage((int)(60 * ((float)10 / armor)));
            try {
                Destroy(ouch.GetComponentInParent<GameObject>());
            }

            catch
            {

            }
            
        }
        if(ouch.gameObject.tag == "levelchange")
        {
            var nextlvl = ouch.gameObject.GetComponent<Next_Level>();
            nextlvl.ChangeLevel();
        }

        if (ouch.gameObject.tag == "Health")
        {
            ChangeHealth(ouch.GetComponent<Health>().deltaHealth);
            ouch.gameObject.SetActive(false);
        }

        if (ouch.gameObject.tag == "Poison")
        {
            ChangeHealth(ouch.GetComponent<Poison>().deltaHealth);
            ouch.gameObject.SetActive(false);
        }

        if (ouch.gameObject.tag == "Gold")
        {
            AddScore(ouch.GetComponentInParent<Gold>().deltaScore);
            
            try
            {
                Destroy(ouch.GetComponentInParent<GameObject>());
            }
            catch
            {

            }
        }

        if (ouch.gameObject.tag == "Armor")
        {
            AddArmor(ouch.GetComponent<Armor>().deltaArmorLevel);
            ouch.gameObject.SetActive(false);
        }


        else
        {

        }
    }
}
