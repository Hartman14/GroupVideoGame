using UnityEngine;
using System.Collections;

public class CameraView: MonoBehaviour {
	// public float lookSensitivity = 5f;
	float yRotation;
	float xRotation;
	public float currentXRotation;
	public float currentYRotation;
	float yRotationView;
	float xRotationView;
	public float rotationSmoothness = 0.1f;
    public GameObject cameraView;

	// Update is called once per frame
	void Update () {
	
		yRotation = Input.GetAxis ("Mouse Y") * rotationSmoothness;
		xRotation = Input.GetAxis ("Mouse X") * rotationSmoothness;

		xRotation = Mathf.Clamp (xRotation, -60f, 80f);

		currentXRotation = Mathf.SmoothDamp (currentXRotation, xRotation, ref xRotationView, rotationSmoothness);
		currentYRotation = Mathf.SmoothDamp (currentYRotation, yRotation, ref yRotationView, rotationSmoothness);

		cameraView.transform.rotation = Quaternion.Euler (xRotation, yRotation, 0f);

	}
}
