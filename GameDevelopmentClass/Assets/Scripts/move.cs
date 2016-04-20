/* DSA
 *Apr 7, 2016
 */
using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;

    public bool invertVertical;
	public float speedH = 4.0f;  //horizontal x axis
	public float speedV = 3.0f;	 //veritcal y axis

	private float yaw = 0.0f;
	private float pitch = 0.0f;
	public int invertControls = 1;


	private Vector3 moveDirection = Vector3.zero;
	void Update() {


		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;

		}
		if (Time.deltaTime > 0) {
			rotate ();
		}
		//print (Time.deltaTime);
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
		transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
	}
}