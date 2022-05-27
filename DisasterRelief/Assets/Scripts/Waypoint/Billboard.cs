using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    [SerializeField] Transform playerCam;

    void LateUpdate()
    {
        transform.LookAt(transform.position + playerCam.transform.rotation * Vector3.forward, playerCam.transform.rotation * Vector3.up);
        Vector3 eulerAngles = transform.eulerAngles;
        eulerAngles.z = 0;
        eulerAngles.x = 0;

        transform.eulerAngles = eulerAngles;
    }
}
