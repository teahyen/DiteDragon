using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDistroy : MonoBehaviour
{
    [Header("건들면 사라지는 친구")]
    [SerializeField]
    public GameObject explosinPrefab;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            StartCoroutine(BlockChoi());
        }
    }

    IEnumerator BlockChoi()
    {
        yield return new WaitForSeconds(1f);
        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;

        yield return new WaitForSeconds(3f);

        GetComponent<Collider2D>().enabled = true;
        GetComponent<SpriteRenderer>().enabled = true;
    }
}
