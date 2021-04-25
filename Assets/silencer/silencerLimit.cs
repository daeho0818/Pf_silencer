using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silencerLimit : MonoBehaviour
{
    static public silencerLimit instance;
    public BoxCollider2D bound;
    private Vector3 minBound;
    private Vector3 maxBound;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    void Start()
    {
        minBound = bound.bounds.min;
        maxBound = bound.bounds.max;
    }
    void Update()
    {
        if (gameObject != null)
        {          
            float clampedX = Mathf.Clamp(transform.position.x, minBound.x  , maxBound.x);
            float clampedY = Mathf.Clamp(transform.position.y, minBound.y , maxBound.y);

            transform.position = new Vector3(clampedX, clampedY, transform.position.z);
        }
    }
    public void SetBound(BoxCollider2D newBound)
    {
        bound = newBound;
        minBound = bound.bounds.min;
        maxBound = bound.bounds.max;
    }
}
