using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    [SerializeField]
    GameObject CoolerPlane;

    [SerializeField]
    GameObject Bolt;

    [SerializeField]
    float MaxHeight = 10;

    private bool LightningDone = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Player position is: " + CoolerPlane.transform.position.y);

        if (CoolerPlane.transform.position.y >= MaxHeight)
        {
            if (!LightningDone)
            {
                LightningDone = true;
                Instantiate(Bolt, new Vector3(CoolerPlane.transform.position.x, CoolerPlane.transform.position.y, CoolerPlane.transform.position.z), Quaternion.identity);
            }
        }
    }
}
