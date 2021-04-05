using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile_move : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        StartCoroutine(FireCycleControl());
    }
    IEnumerator FireCycleControl()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
