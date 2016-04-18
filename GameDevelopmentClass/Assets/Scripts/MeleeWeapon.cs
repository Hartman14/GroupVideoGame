using UnityEngine;
using System.Collections;

public class MeleeWeapon : MonoBehaviour {

    public GameObject Sword;

    public AnimationClip SwordAttack;

    public float Damage;

    bool InAction = false;

    // Use this for initialization
    void Start()
    {

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
        if (!GetComponent<Animation>().isPlaying)
        {
            InAction = false;
        }
    }

}
