using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class OptionsMenu : MonoBehaviour {

    public Canvas OptionsView;
    public Toggle InvertControls;
    public Toggle MiniMapToggle;
    private string sliderName = "sensitivityValue";
    public Slider Sensitivity;
    public Text sliderText;


    public string minimapName = "minimap";  //only for consistenct for saving to playerpref
	// Use this for initialization
	void Start () {
      
        
        Sensitivity.minValue = 1;
        Sensitivity.maxValue = 3;
       if(  PlayerPrefs.HasKey(sliderName)){
            float slidervalue = PlayerPrefs.GetFloat(sliderName);
           // print("PlayerPrefs sensitivity value "+ slidervalue);
            sliderText.text = "Sensitivity: "+ slidervalue;
            Sensitivity.value = slidervalue;
      }
        setInvertControlsToggle();
        setMiniMapToggle();
       

    }

    static void SetBool(string name, bool value)
    {


        PlayerPrefs.SetInt(name, value ? 1 : 0);

    }
    static bool GetBool(string name)
    {
        return PlayerPrefs.GetInt(name) == 1 ? true : false;
    }


    public void minimapsToggle()
    {
        bool value = MiniMapToggle.isOn;
        if (value)
        {
            Debug.Log("if minimap toggle value: " + value);
            PlayerPrefs.SetInt("minimap", 1);
        }
        else
        {
            Debug.Log("else minimap toggle value: " + value);
            PlayerPrefs.SetInt(minimapName, 0);
        }
        PlayerPrefs.Save();
    }
    // 1 for true mini map on
    public void setMiniMapToggle()
    {
        if (PlayerPrefs.GetInt(minimapName) == 1)
        {
            Debug.Log("if minimap value playerpref: = true");
            MiniMapToggle.isOn = true;
        }
        else
        {
            Debug.Log("if minimap value playerpref: = false");
            MiniMapToggle.isOn = false;
        }

    }


    // -1 is true for inverted controls
    public void setInvertControlsToggle()
    {
        if (PlayerPrefs.GetInt("invertControls") ==-1)
        {
            Debug.Log("if invert toggle value playerpref: = true");
            InvertControls.isOn = true;
        }
        else
        {
            Debug.Log("if invert toggle value playerpref: = false");
            InvertControls.isOn = false;
        }
    
    }


    public void invertControlsToggle()
    {
        bool value = InvertControls.isOn;
        if (value)
        {
            Debug.Log("if invert toggle value: " + value);
            PlayerPrefs.SetInt("invertControls", -1);
        }else
        {
            Debug.Log("else invert toggle value: "+ value);
            PlayerPrefs.SetInt("invertControls", 1);
        }
        PlayerPrefs.Save();
    }
    
     public void sensitivitySlider()
    {
        float value = Sensitivity.value;
        sliderText.text = "Sensitivity: "+value;
        Debug.Log("initial value of sens slider"+value);
       PlayerPrefs.SetFloat(sliderName, value);
        PlayerPrefs.Save();
        //print("PlayerPrefs sensitivity value " + PlayerPrefs.GetFloat(sliderName));
    }

	// Update is called once per frame
	void Update () {
	
	}
}
