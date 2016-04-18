using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    
    
    public float movementSpeed = 20f;
    public float jumpSpeed = 200f;
    float yRotation;
    float xRotation;
    float currentXRotation;
    float currentYRotation;
    public float GUISize = 250f;
    float yRotationView = 50f;
    float xRotationView = 50f;
    public float rotationSmoothness = 10f;
    public float sensitivity = 3;

    public GameObject playerCamera;
    public GameObject player;
    public Rigidbody controller;

    Vector3 newPosition;

    //bool onGround = false;

    void Start()
    {
    }

    // Update is called once per frame
    void Update () {

        //rotates player
        rotatePlayer();

        //move to postion
        moveToPosition();

    }

    //moves character, all movements are opposite in game as the mape was creates backwards(ie: only way to compensate)
    void moveToPosition()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            newPosition = playerCamera.transform.right * (Time.deltaTime * movementSpeed);
            newPosition.y = 0f;
            player.transform.position += newPosition;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            newPosition = -1 * playerCamera.transform.right * (Time.deltaTime * movementSpeed);
            newPosition.y = 0f;
            player.transform.position += newPosition;
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            newPosition = playerCamera.transform.forward * (Time.deltaTime * movementSpeed);
            newPosition.y = 0f;
            player.transform.position += newPosition;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            newPosition = -1 * playerCamera.transform.forward * (Time.deltaTime * movementSpeed);
            newPosition.y = 0f;
            player.transform.position += newPosition;
        }
    }

    //rotates player
    void rotatePlayer()
    {
        var recdown = new Rect(0f, 0f, Screen.width, GUISize);
        var recup = new Rect(0, Screen.height - GUISize, Screen.width, GUISize);
        var recleft = new Rect(0, 0, (GUISize * 1.5f), Screen.height);
        var recright = new Rect(Screen.width - (GUISize * 1.5f), 0, (GUISize * 1.5f), Screen.height);

        if (recup.Contains(Input.mousePosition))
        {
            xRotation = Mathf.SmoothDamp(currentXRotation, currentXRotation++, ref xRotationView, rotationSmoothness * Time.deltaTime);
            xRotation = Mathf.Clamp(xRotation, -60f, 80f);
            controller.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        }

        if (recdown.Contains(Input.mousePosition))
        {
            xRotation = Mathf.SmoothDamp(currentXRotation, currentXRotation--, ref xRotationView, rotationSmoothness * Time.deltaTime);
            xRotation = Mathf.Clamp(xRotation, -60f, 80f);
            controller.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        }

        if (recright.Contains(Input.mousePosition))
        {
            //yRotation = Input.GetAxis("Mouse Y") * rotationSmoothness;
            yRotation = Mathf.SmoothDamp(currentYRotation, currentYRotation+=sensitivity, ref yRotationView, rotationSmoothness * Time.deltaTime);

            controller.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        }

        if (recleft.Contains(Input.mousePosition))
        {
            //yRotation = Input.GetAxis("Mouse Y") * rotationSmoothness;
            yRotation = Mathf.SmoothDamp(currentYRotation, currentYRotation-=sensitivity, ref yRotationView, rotationSmoothness * Time.deltaTime);

            controller.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        }
    }

}
