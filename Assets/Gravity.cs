using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public string gravityAffectedTag = "GravityAffected";
    private bool gravityInverted = false;

    void Update()
    {
        // Check if the space bar is pressed
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 newGravity = Physics2D.gravity;
            newGravity.y *= -1;
            Physics2D.gravity = newGravity;
        }
    }
}
