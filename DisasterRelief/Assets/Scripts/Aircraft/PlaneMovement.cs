using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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

    float pitchInput;
    float yawInput;
    float rollInput;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        planeRotation = transform.localRotation.eulerAngles.z;
        print(planeRotation);
 
        transform.position = new Vector3(transform.position.x, transform.position.y - downForce, transform.position.z);
        transform.position += transform.forward * Time.deltaTime * mvSpeed;

        if (yawInput != 0)
        {
            if (Mathf.Abs(yawAmount) < Mathf.Abs(yawInput))
            {
                yawAmount += yawInput * yawAccel * Time.deltaTime;
            }
        }
        else
        {
            if (Mathf.Abs(yawAmount) > 0)
            {
                yawAmount -= yawDeccel * Mathf.Sign(yawAmount) * Time.deltaTime;
            }
        }

        if (pitchInput != 0)
        {
            if (Mathf.Abs(pitchAmount) < Mathf.Abs(pitchInput))
            {
                pitchAmount += pitchInput * pitchAccel * Time.deltaTime;
            }
        }
        else
        {
            if (Mathf.Abs(pitchAmount) > 0)
            {
                pitchAmount -= pitchDeccel * Mathf.Sign(pitchAmount) * Time.deltaTime;
            }
        }

        if (rollInput != 0)
        {
            if (Mathf.Abs(rollAmount) < Mathf.Abs(rollInput))
            {
                rollAmount -= rollInput * rollAccel * Time.deltaTime;
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

    void OnPitch(InputValue value)
    {
        pitchInput = value.Get<float>();
    }

    void OnYaw(InputValue value)
    {
        yawInput = value.Get<float>();
    }

    void OnRoll(InputValue value)
    {
        rollInput = value.Get<float>();
    }

    public void SetMoveSpeed(float newSpeed)
    {
        mvSpeed = newSpeed;
    }
}
