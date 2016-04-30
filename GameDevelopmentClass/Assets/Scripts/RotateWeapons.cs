using UnityEngine;
using System.Collections;

public class RotateWeapons : MonoBehaviour {

    public GameObject Sword;
    public GameObject Bow;

    bool sword = false;
    bool bow = false;

	// Use this for initialization
	void Start () {
        sword = true;
	}
	
	// Update is called once per frame
	void Update () {

        if (gameObject.GetComponent<Inventory>().IsDead())
        {
            //Yup you Dead alright
        }

        else {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Rotate();
            }
            isActive();
        }
	}

    void Rotate()
    {
        
        if(sword)
        {
            sword = false;
            bow = true;
        }

        else if (bow)
        {
            bow = false;
            sword = true;
        }

    }

    void isActive()
    {

        if (sword)
        {
            Sword.SetActive(true);
            Bow.SetActive(false);
        }

        if (bow)
        {
            Sword.SetActive(false);
            Bow.SetActive(true);
        }

    }

}
