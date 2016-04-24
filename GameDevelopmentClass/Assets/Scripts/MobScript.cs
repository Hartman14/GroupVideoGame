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

    Transform player;

    private int stunDuration;

    Vector3 newPosition;

    public AnimationClip running;
    public AnimationClip attack;
    public AnimationClip idle;
    

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
    
       if (!inRange() && (noticeRange <= (Vector3.Distance(transform.position, player.position))))
       {
           chase();
       }

       else
       {
           GetComponent<Animation>().CrossFade(idle.name);
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

    //chases player
    void chase()
    {
        transform.LookAt(player.position);
        newPosition = controller.transform.forward * (Time.deltaTime * speed);
        newPosition.y -= gravity * Time.deltaTime;
        controller.Move(newPosition);
        GetComponent<Animation>().CrossFade(running.name);
    }
    
    
}
