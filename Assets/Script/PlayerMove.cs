using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerMove : MonoBehaviour
{

  
    [SerializeField]
    public float movePover = 1f;

    
    void FixedUpdate()
    {
        Move();
       

    }
    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveVelocity = Vector3.left;
        }

        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveVelocity = Vector3.right;
        }
        transform.position += moveVelocity * movePover * Time.deltaTime;
    }
}
