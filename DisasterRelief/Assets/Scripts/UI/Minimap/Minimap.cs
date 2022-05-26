using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap: MonoBehaviour
{
    public Transform target;
    public Transform marker;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, 300, target.position.z);
        marker.position = new Vector3(target.position.x, 150, target.position.z);
        marker.eulerAngles = new Vector3(90, target.eulerAngles.y, 0);
    }
}
