using UnityEngine;
using System.Collections;

public class RangedWeapon : MonoBehaviour {

    Enemy foe;
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
       
        PlayerObj = GameObject.FindGameObjectWithTag("Player");
        PlayersCamera = PlayerObj.GetComponentInChildren<Camera>();
       // Player = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKeyDown(KeyCode.Mouse0) && !InAction)
        {
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
		
	
		//projectile = (GameObject)Instantiate(Arrow, Arrow.transform.position, Arrow.transform.rotation);

		//projectile.transform.Rotate(Arrow.transform.rotation);
		//projectile.GetComponent<Rigidbody>().AddForce(-transform.right* ArrowSpeed * 100);
		//projectile=(GameObject)Instantiate(Arrow, ShotSpawn.transform.position, Player.rotation);
       projectile=(GameObject)Instantiate(Arrow,ShotSpawn.transform.position, ShotSpawn.gameObject.transform.rotation);
        // projectile = (GameObject)Instantiate(Arrow, ShotSpawn.transform.position, Quaternion.identity);
        //projectile.transform.Rotate(Player.rotation.z, Player.rotation.x + 270f, Player.rotation.y);
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
