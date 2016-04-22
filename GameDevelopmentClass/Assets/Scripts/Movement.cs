﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{


    public float movementSpeed = 20f;
    public float jumpSpeed = 200f;
    public float sensitivity = 2;

    public float speedH = 6.0f;  //horizontal x axis
    public float speedV = 4.0f;  //veritcal y axis

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    public int invertControls = -1;


    public CharacterController controller;

    Vector3 newPosition;

    //bool onGround = false;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //rotates player
        rotate();

        //move to postion
        moveToPosition();


    }

    //moves character, all movements are opposite in game as the mape was creates backwards(ie: only way to compensate)
    void moveToPosition()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            newPosition = controller.transform.right * (Time.deltaTime * movementSpeed) * invertControls;
            newPosition.y = 0f;
            controller.Move(newPosition);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            newPosition = -1 * controller.transform.right * (Time.deltaTime * movementSpeed) * invertControls;
            newPosition.y = 0f;
            controller.Move(newPosition);
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            newPosition = controller.transform.forward * (Time.deltaTime * movementSpeed) * invertControls;
            newPosition.y = 0f;
            controller.Move(newPosition);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            newPosition = -1 * controller.transform.forward * (Time.deltaTime * movementSpeed)* invertControls;
            newPosition.y = 0f;
            controller.Move(newPosition);
        }
    }

    //rotates player
    public void rotate()
    {
        //x axis rotation
        //do not use deltatime multiplication to pause the mouse movements,  deltatime is not 1 and zero. its more like .02  ,,, Dan
        yaw += speedH * Input.GetAxis("Mouse X") * sensitivity;

        //y axis pitch
        pitch = pitch - (speedV * Input.GetAxis("Mouse Y") * invertControls * (sensitivity * .5f));

        if (pitch > 40)
        { // prevents the player from pitching too far forward.
            pitch = 40;
        }
        if (pitch < -60)
        {  //prevents the player from pitching too far up.
            pitch = -60;
            //print (pitch);
        }
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

    }

}