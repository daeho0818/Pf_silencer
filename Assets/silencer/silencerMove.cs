using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silencerMove : MonoBehaviour
{
    Rigidbody rigid;
    public float enemySpeed;
    int nextMoveX;
    int nextMoveY;    

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        Think();

        InvokeRepeating("Think", 0, 2);
        
    }
    
    void FixedUpdate()
    {
        rigid.velocity = new Vector3(nextMoveX, nextMoveY, transform.position.z);
        
    }

    void Think()
    {
        nextMoveX = Random.Range(-1, 2);
        nextMoveY = Random.Range(-1, 2);
    }

}
