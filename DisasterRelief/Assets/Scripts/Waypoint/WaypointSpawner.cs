using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PackageDrop.OnDrop += SpawnWaypoint;
        SpawnWaypoint(transform);
    }

    public void SpawnWaypoint(Transform package)
    {
        int x = Random.Range(-5000, 5000);
        int z = Random.Range(-5000, 5000);
        transform.position = new Vector3(x, 190, z);
    }
}
