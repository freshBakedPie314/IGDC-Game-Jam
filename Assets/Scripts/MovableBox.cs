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
    public bool isGrounded;
    //public float gCRadius;
    void Start()
    {
        //gCRadius = 0.84f;
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

        //Collider2D[] groundCheck = Physics2D.OverlapCircleAll(transform.position, transform.localScale.x*1.414f);
        //if(groundCheck.Length <= 1)
        //{
        //    isGrounded = false;
        //    rb.velocity = new Vector2(0f , rb.velocity.y);
        //}
        //else
        //    isGrounded= true;
    }

    //private void OnDrawGizmosSelected()
    //{
    //    Gizmos.DrawWireSphere(transform.position, gCRadius);
    //}
}
