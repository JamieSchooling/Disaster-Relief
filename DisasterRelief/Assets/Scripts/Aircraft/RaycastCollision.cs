using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCollision : MonoBehaviour
{
    public float rayLength = 5;

    public System.Action<RaycastHit> OnRaycastCollision;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(gameObject.transform.position, Vector3.forward, out hit, rayLength))
        {
            OnRaycastCollision?.Invoke(hit);
            Debug.Log(hit.transform.name);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
