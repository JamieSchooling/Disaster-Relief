using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 positionOffset = Vector3.zero;
    public Vector3 rotationOffset = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.TransformPoint(positionOffset);
        transform.eulerAngles = new Vector3(player.transform.eulerAngles.x + rotationOffset.x, player.transform.eulerAngles.y + rotationOffset.y, rotationOffset.z);
    }
}
