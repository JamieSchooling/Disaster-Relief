using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainDetection : MonoBehaviour
{

    public GameObject plane;
    public float maxDistance = 5;
    public Death death;

    RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(plane.transform.position, Vector3.forward, out hit, maxDistance) && hit.transform.tag == "Terrain")
        {
            death.PlayerDeath();
        }
    }
}
