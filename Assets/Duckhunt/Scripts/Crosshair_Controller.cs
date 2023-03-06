using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class Crosshair_Controller : MonoBehaviour
{
    public float speed;

    private Vector2 dir;

    void Update()
    {
        dir = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics2D.OverlapCircle(transform.position, 0.25f) && Physics2D.OverlapCircle(transform.position, 0.25f).CompareTag("Enemy"))
            {
                Physics2D.OverlapCircle(transform.position, 0.25f).gameObject.GetComponent<enem>().dead = true;
            }
        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = dir * speed;
    }
}
