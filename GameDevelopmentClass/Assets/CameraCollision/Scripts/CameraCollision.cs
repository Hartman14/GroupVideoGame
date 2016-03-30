using UnityEngine;
using System.Collections;
//THIS SCRIPT IS USED TO PREVENT THE CAMERA FROM GOING THROUGH WALLS
//ATTACH THIS SCRIPT TO A CAMERA

public class CameraCollision : MonoBehaviour {
	public bool canScroll = true; //whether or not you can zoom in and out
	public Transform focusPoint; //used as the focal rotation point, and raycast point | must be centered on the player(x and z)
	public float detectionRadius = 0.15f; //radius detection | used to prevent the camera from peering through when standing up against a wall
	public float zoomIntensiity = 1.0f; //the distance the camera will zoom per scroll
	public int maxZoomOut = 5; //used to limit distance you can zoom out, away from your character
	private int maxZoomIn; //used to limit distance you can zoom in, towards your character
	private RaycastHit hit; //used to detect objects in front of camera
	private GameObject camFollow; //monitors camera's position
	private GameObject camSpot; //camera's destination | used for zooming camera in and out
	public string[] maskedTags; //if you have an object you do not wish for the camera to detect, give the object a tag, and add the name of that tag to this list, in the inspector | the object will be ignored
	//IF YOU WISH TO USE ANOTHER SCRIPT, ALONG WITH THIS ONE, THAT INCORPERATES ZOOMING, YOU MUST ZOOM THIS VARIABLE [camSpot], NOT THE CAMERA ITSELF!
	//This variable is a gameObject, created on start (just below)

	//Use this for initialization
	void Start () {
		focusPoint = transform.parent.transform;

		//create camSpot
		camSpot = new GameObject();
		camSpot.transform.name = "CameraSpot";
		camSpot.transform.parent = transform.parent;
		camSpot.transform.position = transform.position;
		camSpot.hideFlags = HideFlags.HideInHierarchy;
		
		//create camFollow
		camFollow = new GameObject();
		camFollow.transform.name = "CameraFollow";
		camFollow.transform.parent = transform.parent;
		camFollow.transform.position = focusPoint.position;
		//make sure the camFollow is looking at the camera
		camFollow.transform.LookAt(transform);
		camFollow.hideFlags = HideFlags.HideInHierarchy;
		
		//Set maxZoomIn distance to not exceed starting distance from camera to focusPoint
		maxZoomIn = (int)(Vector3.Distance(transform.position, focusPoint.transform.position) / zoomIntensiity);
	}
	
	// Update is called once per frame
	void Update () {
		//If player mouse-scrolls foward
		if(Input.GetAxis("Mouse ScrollWheel") > 0) {
			if(canScroll == true) {
				//can only zoom in four intervals from camSpot's starting pos
				if(maxZoomIn > 0) {
					//zoom camSpot in
					camSpot.transform.position = camSpot.transform.position + zoomIntensiity * -camFollow.transform.forward;
					maxZoomOut += 1; maxZoomIn -= 1;
				}
			}
		}
		//If player mouse-scrolls backward
		if(Input.GetAxis("Mouse ScrollWheel") < 0) {
			if(canScroll == true) {
				//can only zoom out four intervals from camSpot's starting pos
				if(maxZoomOut > 0) {
					//zoom camSpot out
					camSpot.transform.position = camSpot.transform.position - zoomIntensiity * -camFollow.transform.forward;
					maxZoomOut -= 1; maxZoomIn += 1;
				}
			}
		}
		
		//distance between camFollow and camSpot
		float distFromCamSpot = Vector3.Distance(camFollow.transform.position, camSpot.transform.position);
		//distance between camFollow and camera
		float distFromCamera = Vector3.Distance(camFollow.transform.position, transform.position);
		
		//ShereCast from camFollow to camSpot
		if(Physics.SphereCast(camFollow.transform.position, detectionRadius, camFollow.transform.forward, out hit, distFromCamSpot)) {
			//**MAKE SURE YOUR PLAYER IS NOT BETWEEN THE FOCUS-POINT AND CAMERA**
			//get distance betwen camFollow and hitPoint of raycast
			var distFromHit = Vector3.Distance(camFollow.transform.position, hit.point);
			//if camera is behind an object, immediately put it in front
			if(distFromHit < distFromCamera) {
				//if player is ver close to a wall, bring camera inward, 
				//but do not exceed the camFollow's position (dont put camera in front of player)
				bool maskedHit = false;
				//check to see if what we hit was tagged
				foreach(string myTag in maskedTags) {
					if(hit.transform.tag == myTag) {
						maskedHit = true;
					}
				}
				if(maskedHit == false) {
					if(distFromCamera > 1) {
						transform.position = hit.point + 1 * -camFollow.transform.forward;
					}
					else {
						transform.position = camFollow.transform.position;
					}
				}
			}
			else {
				//if player is ver close to a wall, bring camera inward, 
				//but do not exceed the camFollow's position (dont put camera in front of player)
				bool maskedHit = false;
				//check to see if what we hit was tagged
				foreach(string myTag in maskedTags) {
					if(hit.transform.tag == myTag) {
						maskedHit = true;
					}
				}
				if(maskedHit == false) {
					if(distFromCamera > 1) {
						transform.position = Vector3.MoveTowards(transform.position, hit.point + 1 * -camFollow.transform.forward, 5 * Time.deltaTime);
					}
					else {
						transform.position = Vector3.MoveTowards(transform.position, camFollow.transform.position, 5 * Time.deltaTime);
					}
				}
			}
		}
		else {
			//ease camera back to camSpot
			transform.position = Vector3.MoveTowards(transform.position, camSpot.transform.position, 5 * Time.deltaTime);
		}
	}
}
