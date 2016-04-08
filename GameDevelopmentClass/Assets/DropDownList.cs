using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public class DropDownList : MonoBehaviour {

	public List<string> testList = new List<string> ();
	public Dropdown DropDownListObject;


	// Use this for initialization

	void Start () {



	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void testUpdateList(){

		testList.Add ("Documentation sucks");
		DropDownListObject.AddOptions (testList);
	}

}
