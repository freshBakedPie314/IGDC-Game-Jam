using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableBox : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public Transform point;
    public float radius;
    public LayerMask layerMask;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D[] collisions = Physics2D.OverlapCircleAll(point.position, radius , layerMask);
        if(collisions.Length > 1)
        {
            rb.mass = 0f;
        }
    }
}
