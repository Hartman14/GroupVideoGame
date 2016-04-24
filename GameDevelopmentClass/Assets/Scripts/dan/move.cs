/* DSA
 *Apr 7, 2016
 */
using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float speed = 15.0F;
	public float jumpSpeed = 10.0F;
    public float gravity = 20.0F;

    public bool invertVertical;
	public float speedH = 6.0f;  //horizontal x axis
	public float speedV = 5.0f;	 //veritcal y axis

	private float yaw = 0.0f;
	private float pitch = 0.0f;
	public int invertControls = 1;


	private Vector3 moveDirection = Vector3.zero;
	void Update() {

		// structure of method  public Vector3 TransformDirection(Vector3 direction);  //    Transforms direction x, y, z from local space to world space.

		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) { //player is on the ground, and thus not in the air 
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // gets the input direction, and use the input managers defined controls
			moveDirection = transform.TransformDirection(moveDirection); //
			moveDirection *= speed;
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;

		}
		if (Time.deltaTime > 0) {
			rotate ();
		}
		//print (Time.deltaTime);  // deltaTime is a value less than 1 but greater than 0 normally
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}


	public void StartMenu(){
		MenuScript menu = new MenuScript ();
		if(Input.GetKeyDown(KeyCode.Escape)){
			menu.openStartMenu();
		}

	}



	public void rotate(){
		//x axis rotation
		//do not use deltatime multiplication to pause the mouse movements,  deltatime is not 1 and zero. its more like .02  ,,, Dan
		//it does work to do          if(Time.deltaTime > 0){ rotate();} in the update

		yaw   += speedH * Input.GetAxis("Mouse X");

		//y axis pitch
		pitch = pitch - speedV * Input.GetAxis("Mouse Y")*invertControls;

		if (pitch > 40) { // prevents the player from pitching too far forward.
			pitch = 40;
		}
		if (pitch <-60 ) {  //prevents the player from pitching too far up.
			pitch = -60;
			//print (pitch);
		}
		transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);

		GetComponentInChildren<Camera>().transform.eulerAngles = new Vector3 (pitch, yaw, 0.0f);

	}
}