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
   
	// Use this for initialization
	void Start () {
        playerInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();   //works assuming tag has been set
        setDisplayHealth(playerInventory.GetMaxHealth(), playerInventory.GetHealth());
        
       // print(player.name);
        /*
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
	}

    void switchWeaponImage(string weapon)
    {
        if (weapon.Equals("sword")){

        }
    }

   public void setDisplayHealth(int maxHealth, int currentHealth)
    {

        string healthString= currentHealth + "/" + maxHealth;
        HealthValueDisplay.text = healthString;
       
    }
}
