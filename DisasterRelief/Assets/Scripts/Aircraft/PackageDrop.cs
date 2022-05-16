using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageDrop : MonoBehaviour
{
    public Transform dropPoint;
    public GameObject package;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown("space"))
        {
            Instantiate(package, new Vector3(dropPoint.position.x, dropPoint.position.y, dropPoint.position.z), Quaternion.identity);
        }
        */
    }

    void OnDropPackage()
    {
        Instantiate(package, new Vector3(dropPoint.position.x, dropPoint.position.y, dropPoint.position.z), Quaternion.identity);
    }
}
