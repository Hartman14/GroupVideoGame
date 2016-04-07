using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    
    
    public float movementSpeed = 20f;
    public float jumpSpeed = 200f;
    public float GUIsize = 100f;
    float yRotation;
    float xRotation;
    float currentXRotation;
    float currentYRotation;
    public float GUISize = 50f;
    float yRotationView;
    float xRotationView;
    public float rotationSmoothness = .1f;

    public GameObject playerCamera;
    public GameObject player;
    public CharacterController controller;
    

    bool onGround = false;

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
            controller.transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            controller.transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            controller.transform.position += Vector3.back * movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            controller.transform.position += Vector3.forward * movementSpeed * Time.deltaTime;
        }
    }

    //rotates player
    void rotatePlayer()
    {
        var recdown = new Rect(0f, 0f, Screen.width, GUISize);
        var recup = new Rect(0, Screen.height - GUISize, Screen.width, GUISize);
        var recleft = new Rect(0, 0, GUISize, Screen.height);
        var recright = new Rect(Screen.width - GUISize, 0, GUISize, Screen.height);

        if (recup.Contains(Input.mousePosition))
        {
            xRotation = Mathf.SmoothDamp(currentXRotation, currentXRotation++, ref xRotationView, rotationSmoothness);
            xRotation = Mathf.Clamp(xRotation, -60f, 80f);
            controller.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        }

        if (recdown.Contains(Input.mousePosition))
        {
            xRotation = Mathf.SmoothDamp(currentXRotation, currentXRotation--, ref xRotationView, rotationSmoothness);
            xRotation = Mathf.Clamp(xRotation, -60f, 80f);
            controller.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        }

        if (recright.Contains(Input.mousePosition))
        {
            //yRotation = Input.GetAxis("Mouse Y") * rotationSmoothness;
            yRotation = Mathf.SmoothDamp(currentYRotation, currentYRotation++, ref yRotationView, rotationSmoothness);

            controller.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        }

        if (recleft.Contains(Input.mousePosition))
        {
            //yRotation = Input.GetAxis("Mouse Y") * rotationSmoothness;
            yRotation = Mathf.SmoothDamp(currentYRotation, currentYRotation--, ref yRotationView, rotationSmoothness);

            controller.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        }
    }

}
