using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class BluckDealy : MonoBehaviour
{
    // n초후 사라지는 블럭
    [SerializeField]
    public GameObject grounddealy;
    public GameObject groundDestroy;
    public Transform wechi;
    public float Dealy;
    private bool DealyState;
 

    private void Start()
    {
        DealyState = true;
    }
    private void Update()
    {
        groundDealy();
    }
    private void groundDealy()
    {
        if (DealyState)
        {
            StartCoroutine(DealyCycleControl());
            Instantiate(grounddealy, wechi.position, wechi.rotation);
        }
       
    }
    IEnumerator DealyCycleControl()
    {
        DealyState = false;
        yield return new WaitForSeconds(3f);
        DealyState = true;
    }
}