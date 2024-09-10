using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Reference to the player's transform
    public float smoothness=10f;
    public float distance = 5f;
    public float height = 2f;
    public float rotationOsffset = 10f;

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position-target.forward*distance;
        desiredPosition += Vector3.up * height;
        Quaternion desiredRotation = Quaternion.Euler(rotationOsffset, target.eulerAngles.y, 0);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothness*Time.deltaTime);

        transform.rotation = Quaternion.Lerp(transform.rotation,desiredRotation, smoothness*Time.deltaTime);
    }
}
