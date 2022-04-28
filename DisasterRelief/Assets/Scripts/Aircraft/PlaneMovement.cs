using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public float gravity = 1.0f;

    public float mvSpeed = 1.0f;

    public float pitchSpeed = 1.0f;
    public float yawSpeed = 1.0f;
    public float rollSpeed = 1.0f;

    public float pitchAccel = 1.0f;
    public float yawAccel = 1.0f;
    public float rollAccel = 1.0f;

    public float pitchDeccel = 1.0f;
    public float yawDeccel = 1.0f;
    public float rollDeccel = 1.0f;

    float pitchAmount = 0;
    float yawAmount = 0;
    float rollAmount = 0;

    float planeRotation;

    float downForce;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        planeRotation = transform.localRotation.eulerAngles.z;

 
        transform.position = new Vector3(transform.position.x, transform.position.y - downForce, transform.position.z);
        transform.position += transform.forward * Time.deltaTime * mvSpeed;

        int h_input = System.Convert.ToInt32(Input.GetKey("d")) - System.Convert.ToInt32(Input.GetKey("a"));
        int v_input = System.Convert.ToInt32(Input.GetKey("w")) - System.Convert.ToInt32(Input.GetKey("s"));
        int o_input = System.Convert.ToInt32(Input.GetKey("q")) - System.Convert.ToInt32(Input.GetKey("e"));

        if (h_input != 0)
        {
            if (Mathf.Abs(yawAmount) < Mathf.Abs(h_input))
            {
                yawAmount += h_input * yawAccel * Time.deltaTime;
            }
        }
        else
        {
            if (Mathf.Abs(yawAmount) > 0)
            {
                yawAmount -= yawDeccel * Mathf.Sign(yawAmount) * Time.deltaTime;
            }
        }

        if (v_input != 0)
        {
            if (Mathf.Abs(pitchAmount) < Mathf.Abs(v_input))
            {
                pitchAmount += v_input * pitchAccel * Time.deltaTime;
            }
        }
        else
        {
            if (Mathf.Abs(pitchAmount) > 0)
            {
                pitchAmount -= pitchDeccel * Mathf.Sign(pitchAmount) * Time.deltaTime;
            }
        }

        if (o_input != 0)
        {
            if (Mathf.Abs(rollAmount) < Mathf.Abs(o_input))
            {
                rollAmount += o_input * rollAccel * Time.deltaTime;
            }
        }
        else
        {
            if (Mathf.Abs(rollAmount) > 0)
            {
                rollAmount -= rollDeccel * Mathf.Sign(rollAmount) * Time.deltaTime;
            }
        }


        transform.Rotate(new Vector3(0, yawSpeed * Time.deltaTime * yawAmount, 0));
        transform.Rotate(new Vector3(pitchSpeed * Time.deltaTime * pitchAmount, 0, 0));
        transform.Rotate(new Vector3(0, 0, rollSpeed * Time.deltaTime * rollAmount));
    }

}
