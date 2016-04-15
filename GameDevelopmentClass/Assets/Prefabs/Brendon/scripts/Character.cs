using UnityEngine;
using System.Collections;

abstract class Character : MonoBehaviour
{

    public int health;

    // Use this for initialization
   

    public abstract void damage(int x);

	// Update is called once per frame
	

    public abstract void death();
   
}
