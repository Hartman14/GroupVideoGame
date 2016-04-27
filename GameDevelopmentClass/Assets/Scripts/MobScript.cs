using UnityEngine;
using System.Collections;

public class MobScript : MonoBehaviour
{

    //variables

    public float speed = 10f;
    public float AttackRange = 5f;
    public float noticeRange = 10f;
    public float gravity = 20.0F;

    public CharacterController controller;
    public GameObject Skeleton;

    Transform player;

    private int stunDuration;

    Vector3 newPosition;

    public AnimationClip running;
    public AnimationClip attack;
    public AnimationClip idle;
    public AnimationClip Dance;


    //-----------------------------------------------------------------------------------------------------------

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    //-----------------------------------------------------------------------------------------------------------

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<Inventory>().GetHealth() <= 0)
        {
            fixRotation();
            GetComponent<Animation>().CrossFade(Dance.name);
        }

        else if (!GetComponent<Animation>().IsPlaying(attack.name))
        {
            if (!inRange() && (noticeRange <= (Vector3.Distance(transform.position, player.position))))
            {
                chase();
            }

            else if (inRange())
            {
                Attack();
            }

            else
            {
                GetComponent<Animation>().CrossFade(idle.name);
            }
        }
    }
    
    //---------------------------------------------------------------------------------------------------------------

    //checks if in range of mob attacks
    bool inRange()
    {
        if ((Vector3.Distance(transform.position, player.position) < AttackRange))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    //-------------------------------------------------------------------------------------------------

   void Attack()
    {
        GetComponent<Animation>().CrossFade(attack.name);
    }

    //chases player
    void chase()
    {
        transform.LookAt(player.position);
        fixRotation();
        newPosition = controller.transform.forward * (Time.deltaTime * speed);
        newPosition.y -= gravity * Time.deltaTime;
        controller.Move(newPosition);
        GetComponent<Animation>().CrossFade(running.name);
    }
    
    void fixRotation()
    {
        transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y, 0f); ;
    }
    
}
