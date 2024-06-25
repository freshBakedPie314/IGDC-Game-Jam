using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Conveyor : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    float dir = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 pos = rb.position;
        rb.position += Vector2.left * speed * Time.fixedDeltaTime * dir;
        rb.MovePosition(pos);

        if (dir > 0)
            GetComponentInChildren<SpriteRenderer>().flipX = false;
        else
            GetComponentInChildren<SpriteRenderer>().flipX = true;

    }

    public void switchDir()
    {
        dir *= -1f;
    }
}
