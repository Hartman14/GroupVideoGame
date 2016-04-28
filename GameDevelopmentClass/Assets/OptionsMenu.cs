using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class OptionsMenu : MonoBehaviour {

    public Canvas OptionsView;
    public Toggle InvertControls;
    private string sliderName = "sensitivityValue";
    public Slider Sensitivity;
    public Text sliderText;
   
	// Use this for initialization
	void Start () {
      
        
        Sensitivity.minValue = 10;
        Sensitivity.maxValue = 100;
       if(  PlayerPrefs.HasKey(sliderName)){
            float slidervalue = PlayerPrefs.GetFloat(sliderName);
           // print("PlayerPrefs sensitivity value "+ slidervalue);
            sliderText.text = "Sensitivity: "+ slidervalue;
            Sensitivity.value = slidervalue;
      }
        setInvertControlsToggle();


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
