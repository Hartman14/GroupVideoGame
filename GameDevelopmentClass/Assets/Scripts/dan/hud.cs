using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class hud : MonoBehaviour {
    public RawImage WeaponImageSword;
    public RawImage WeaponImageBow;
    //public Material SwordImg;
    public RawImage[] item_display;
    private GameObject player;
    private Inventory playerInventory;

    public Text HealthValueDisplay;
    public Text ArmorValueDisplay;
    // Use this for initialization
    void Start () {
        playerInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();   //works assuming tag has been set
        setDisplayHealth(playerInventory.GetMaxHealth(), playerInventory.GetHealth());
        print(playerInventory.name);
       // print(player.name);

        /* //code for images, change of course, were not as important
        List<RawImage> rawImageslist = new List<RawImage>();
        
        RawImage[] RawImage = gameObject.GetComponentsInChildren<RawImage>();
        print(RawImage);
        for(int i = 0; i< RawImage.GetLength(0); i++)
        {
            if (RawImage[i].name.Equals("item_Display"+i))
            {
                print("rawimage "+RawImage[i]);
                rawImageslist.Add(RawImage[i]);
            }
           
        }
        RawImage[] array = rawImageslist.ToArray();
          foreach(RawImage elem in rawImageslist)
        {
            print(elem.name);
        }

            WeaponImage = gameObject.GetComponentInChildren<RawImage>();
        //HealthValueDisplay = gameObject.GetComponentInChildren<Text>(HealthDisplay);
        */
    }
	
	// Update is called once per frame
	void Update () {
        setDisplayHealth(playerInventory.GetMaxHealth(), playerInventory.GetHealth());
        setDisplayArmor(playerInventory.GetMaxArmor(), playerInventory.GetArmor());
        if (Input.GetKeyDown(KeyCode.Period))
        {
            playerInventory.ChangeHealth(5);
        }
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            playerInventory.ChangeHealth(-5);
        }
        if (Input.GetKeyDown(KeyCode.Quote))
        {
            playerInventory.AddArmor(5);
        }
        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            playerInventory.AddArmor(-5);
        }
    }

    void switchWeaponImage(string weapon)
    {
        if (weapon.Equals("sword")){

        }
    }
    public void setDisplayArmor(int max, int current)
    {

        string str = current + "/" + max;
        ArmorValueDisplay.text = str;

    }
    public void setDisplayHealth(int max, int current)
    {

        string str= current + "/" + max;
        HealthValueDisplay.text = str;
       
    }
}
