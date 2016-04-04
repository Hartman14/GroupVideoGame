using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    CameraView cameraView;

    public float playerAcceleration = 500f;
    public float maxSpeed = 20f;
    public float jumpSpeed = 200f;
    public float maxSlope = 60f;
    float deacceleration;
    float deaccelerationX = 10f;
    float deaccelerationZ = 10f;

    Vector2 horizontalMovement;

    public GameObject playerCamera;
    public GameObject player;

    bool onGround = false;

	// Update is called once per frame
	void Update () {

        horizontalMovement = new Vector2(player.GetComponent<Rigidbody>().velocity.x, player.GetComponent<Rigidbody>().velocity.z);

        if(horizontalMovement.magnitude > maxSpeed)
        {
            horizontalMovement = horizontalMovement.normalized;
            horizontalMovement *= maxSpeed;
        }

        //work in progress, Slows down player object at a faster rate
        /*player.GetComponent<Rigidbody>().velocity.x = horizontalMovement.x;
        player.GetComponent<Rigidbody>().velocity.z = horizontalMovement.y;

        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            player.GetComponent<Rigidbody>().velocity.x = Mathf.SmoothDamp(player.GetComponent<Rigidbody>().velocity.x, 0f, ref deaccelerationX, deacceleration);
            player.GetComponent<Rigidbody>().velocity.z = Mathf.SmoothDamp(player.GetComponent<Rigidbody>().velocity.z, 0f, ref deaccelerationZ, deacceleration);
        }*/

        //work in progress, will be fixed once i can see my older code. down side of being in mexico, no desktop :(
        //cameraView.transform.rotation = Quaternion.Euler(0f, cameraView.currentYRotation, 0f);
        player.GetComponent<Rigidbody>().AddRelativeForce(Input.GetAxis("Horizontal") * playerAcceleration* Time.deltaTime, 0, Input.GetAxis("Vertical") * playerAcceleration * Time.deltaTime);

        //the jumping action, work in progress as this is a first for me and i have nothing but email in mexico
        if(Input.GetButtonDown("Jump") && onGround)
        {
            player.GetComponent<Rigidbody>().AddForce(0f, jumpSpeed, 0f);
        }
	}
}
