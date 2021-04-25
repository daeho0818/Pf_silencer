using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //WASD로 움직이기

    public float maxSpeed;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, maxSpeed * Time.deltaTime, 0);            
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -maxSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-maxSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(maxSpeed * Time.deltaTime, 0, 0);
        }
    }
}