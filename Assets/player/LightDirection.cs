using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDirection : MonoBehaviour
{
    Vector2 target, mouse;

    void Start()
    {
        target = transform.position;

    }
    void Update()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target = new Vector2(mouse.x, mouse.y); 
        transform.LookAt(target);
    }
}