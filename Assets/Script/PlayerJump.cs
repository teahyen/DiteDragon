using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpSeed = 5f;
    public bool isGround = true;
    Rigidbody2D rd;


    private void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGround)
            {
                isGround = false;
                rd.AddForce(Vector2.up * jumpSeed, ForceMode2D.Impulse);
            }
        }
    }
}
