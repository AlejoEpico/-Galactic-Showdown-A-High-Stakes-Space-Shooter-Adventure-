using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lighter : MonoBehaviour
{
    private Light lightComponent;

    void Start()
    {
        // Get the Light component attached to this GameObject
        lightComponent = GetComponent<Light>();
    }

    void Update()
    {
        // Toggle the Light component when the L key is pressed
        if (Input.GetKeyDown(KeyCode.L))
        {
            lightComponent.enabled = !lightComponent.enabled;
        }
    }
}
