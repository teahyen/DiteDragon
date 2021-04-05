using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mal : MonoBehaviour
{
    [SerializeField]
    Vector3 pos;
    public GameObject player;
    public GameObject mal;

    public bool isMal;
    
    private void Start()
    {
        isMal = true;
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            StartCoroutine(FireCycleControl());
            
        }
        IEnumerator FireCycleControl()
        {
            if (isMal)
            {
                Instantiate(mal,pos, Quaternion.identity);
            }
            isMal = false;
            yield return new WaitForSeconds(5f);
            isMal = true;
        }
    }
}