
using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;

	public bool invertVertical;
	public float speedH = 3.0f;
	public float speedV = 3.0f;

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
		rotate ();


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
		

			

		yaw += speedH * Input.GetAxis("Mouse X");
		pitch = pitch-  speedV * Input.GetAxis("Mouse Y")*invertControls;

		transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
	}


}