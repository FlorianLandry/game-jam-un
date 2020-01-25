using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public bool lockCursor;
    public float mouseSensitivity = 10;
    public Transform target;
    public float distanceTarget = 4.0f;

    public Vector2 pitchMinMax = new Vector2(-45, 85);

    public float rotSmoothTime = 0.12f;
    Vector3 rotSmoothVelocity;
    Vector3 currentRotation;

    float yaw;
    float pitch;

    private void Start()
    {
        if(lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        yaw += Input.GetAxis("Mouse X") * mouseSensitivity;
        pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        pitch = Mathf.Clamp(pitch, pitchMinMax.x, pitchMinMax.y);

        currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(yaw, pitch), ref rotSmoothVelocity, rotSmoothTime);

        Vector3 targetRotation = new Vector3(pitch, yaw);
        transform.eulerAngles = targetRotation;

        transform.position = target.position - transform.forward * distanceTarget;
    }
}
