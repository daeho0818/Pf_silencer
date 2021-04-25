using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public static Light light;
    private void Start()
    {
        light = GetComponent<Light>();
    }
    void Update()
    {
        if (light.enabled)
        {
            if (Input.GetMouseButtonDown(1))
                light.enabled = false;


        }
        else
        {
            if (Input.GetMouseButtonDown(1))
                light.enabled = true;
        }
            
    }
}