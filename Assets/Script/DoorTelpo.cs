using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTelpo : MonoBehaviour
{
    [Header("텔레포트")]
    [SerializeField]
    public Transform Target;
    public float interactDiastance = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //GameManager.Instance.door = transform.parent.GetComponent<DoorScript>();
    }

    // Update is called once per frame
    public void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (col.tag == "Player")
            {
                col.transform.position = Target.position;
                Ray2D ray = new Ray2D(transform.position, transform.forward);
                 RaycastHit2D hit;

                hit = Physics2D.Raycast(ray.origin, ray.direction);

                 if (hit)
                 {
                    
                    Debug.Log("문이 열렸습니다");
                     if (hit.collider.CompareTag("Door")){
                         hit.collider.transform.parent.GetComponent<DoorScript>().ChangeDoorState();
                     }
                 }

            }
        }
    }
}
