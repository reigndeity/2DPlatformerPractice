using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // ATTACH TO MAIN CAMERA
    public Transform target;
    public Vector2 offset;
    public float smoothSpeed = 0.125f;

    public Vector2 minPosition;
    public Vector2 maxPosition;

    private void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = new Vector3(target.position.x + offset.x, target.position.y + offset.y, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = new Vector3(
                Mathf.Clamp(smoothedPosition.x, minPosition.x, maxPosition.x),
                Mathf.Clamp(smoothedPosition.y, minPosition.y, maxPosition.y),
                transform.position.z
                );   
        }
    }
}
