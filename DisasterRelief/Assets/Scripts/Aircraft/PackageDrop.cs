using System;
using UnityEngine;

public class PackageDrop : MonoBehaviour
{
    public static Action<Transform> OnDrop;

    [SerializeField] Transform dropPoint;
    [SerializeField] GameObject package;
    
    void OnDropPackage()
    {
        GameObject packageGO = Instantiate(package, dropPoint.transform.position, dropPoint.localRotation);
        Destroy(packageGO, 3f);

        OnDrop?.Invoke(packageGO.transform);
    }
}
