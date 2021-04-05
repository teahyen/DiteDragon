using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BlockMove : MonoBehaviour
{
    [SerializeField]
    Vector3 pos;
    [SerializeField]
    float delta = 2.0f;
    [SerializeField]
    float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = pos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
