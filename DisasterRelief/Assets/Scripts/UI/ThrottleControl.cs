using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ThrottleControl : MonoBehaviour
{
    [SerializeField]
    Slider throttle;

    [SerializeField]
    float sensitivity;

    float addValue;
    
    void Update()
    {
        throttle.value += addValue * sensitivity;
    }

    void OnSpeed(InputValue newValue)
    {
        addValue = newValue.Get<float>();
    }
}
