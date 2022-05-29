using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ThrottleControl : MonoBehaviour
{
    [SerializeField]
    Slider throttle;

    float addValue;
    
    void Update()
    {
        throttle.value += addValue;
    }

    void OnSpeed(InputValue newValue)
    {
        addValue = newValue.Get<float>();;
    }
}
