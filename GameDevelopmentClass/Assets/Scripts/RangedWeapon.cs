using UnityEngine;
using System.Collections;

public class RangedWeapon : MonoBehaviour {

    Enemy foe;


    public AudioClip launchArrow;
    private AudioSource arrowSound;

    public GameObject Bow;
    public GameObject Arrow;
    public GameObject ShotSpawn;
    GameObject projectile;
    public GameObject BowArrow;

    private GameObject PlayerObj;

    public Transform Player;
    private Camera PlayersCamera;

    public AnimationClip BowAttack;
    public AnimationClip BowReload;

    public float Damage;
    public float ArrowSpeed;

    bool InAction = false;
    bool ArrowFire = false;
    bool needReload = false;

	// Use this for initialization
	void Start () {
        arrowSound = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKeyDown(KeyCode.Mouse0) && !InAction)
        {
            arrowSound.PlayOneShot(launchArrow, 1f);
            Attack();
        }

        if (!InAction )
        {
            InAction = false;
        }

        if (!GetComponent<Animation>().isPlaying && ArrowFire)
        {
            ArrowFire = false;
            InAction = false;
            BowArrow.SetActive(false);
            needReload = true;
            FireProjectile();
        }

        if (needReload)
        {
            Reload();
        }
        
    }

    void Attack()
    {
        //InAction = true;
        ArrowFire = true;
        GetComponent<Animation>().CrossFade(BowAttack.name);
        
        
    }

    void FireProjectile()
    {
		
        projectile=(GameObject)Instantiate(Arrow,ShotSpawn.transform.position, ShotSpawn.gameObject.transform.rotation);
        projectile.GetComponent<Rigidbody>().AddForce(-transform.right* ArrowSpeed * 100);
        
    }

    public GameObject getProjectile()
    {
        return projectile;
    }

    void Reload()
    {
        BowArrow.SetActive(true);
        needReload = false;
        GetComponent<Animation>().CrossFade(BowReload.name);
        
    }

}
