using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waypoint : MonoBehaviour
{
    [SerializeField] Transform playerCam;
    public Sprite icon;
    [HideInInspector] public Image image;

    public Vector2 position
    {
        get { return new Vector2(transform.position.x, transform.position.z); }
    }

    void LateUpdate()
    {
        transform.LookAt(playerCam.position);
        Vector3 rotationClamp = new Vector3(0, transform.rotation.y, 0);
        transform.rotation = Quaternion.Euler(rotationClamp);
    }
}
