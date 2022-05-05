using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    Vector2 positionOffset = Vector2.zero;

    [SerializeField]
    Vector3 rotationOffset = Vector3.zero;

    [SerializeField]
    float yOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.TransformPoint(new Vector3(positionOffset.x, 0, positionOffset.y));
        transform.position = transform.position + new Vector3(0, yOffset, 0);
        transform.eulerAngles = new Vector3(player.transform.eulerAngles.x + rotationOffset.x, player.transform.eulerAngles.y + rotationOffset.y, rotationOffset.z);
    }
}
