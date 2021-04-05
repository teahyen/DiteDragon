using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDealy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    float time = 0f;
    

    // Update is called once per frame 
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 2)
        {
            Destroy(gameObject);
        }
    }
} 

