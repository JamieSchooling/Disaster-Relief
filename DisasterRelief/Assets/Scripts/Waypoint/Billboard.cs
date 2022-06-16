using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    // Reference to the player camera
    [SerializeField] Transform playerCam;

    // Late update delays movement until after the plane has moved to prevent glitches
    void LateUpdate()
    {
        // Makes the billboard face the camera
        transform.LookAt(transform.position + playerCam.transform.rotation * Vector3.forward, playerCam.transform.rotation * Vector3.up);

        // Locks the rotation to the y-axis
        Vector3 eulerAngles = transform.eulerAngles;
        eulerAngles.z = 0;
        eulerAngles.x = 0;

        // Applies the rotation
        transform.eulerAngles = eulerAngles;
    }
}
