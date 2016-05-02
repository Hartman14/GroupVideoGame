using UnityEngine;
using System.Collections;

public class MeleeWeapon : MonoBehaviour {

    public GameObject Sword;

    public AnimationClip SwordAttack;

    public float Damage;

    public AudioClip atkclip; //franklin
    private AudioSource atkSound;//franklin
   

    bool InAction = false;
    bool Enabled = false;

    // Use this for initialization
    void Start()
    {
        atkSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0) && !InAction)
        {
            Attack();
        }
        if (InAction)
        {
            InAction = false;
        }

    }

    void Attack()
    {
        InAction = true;
        GetComponent<Animation>().CrossFade(SwordAttack.name);
        if (!atkSound.isPlaying) // better but animation time and sound time differ
        {
            atkSound.PlayOneShot(atkclip, .2f);
        }
        
       
        if (!GetComponent<Animation>().IsPlaying(SwordAttack.name))
        {
            Debug.Log("is  not playing ");
            InAction = false;
        }
    }

}
