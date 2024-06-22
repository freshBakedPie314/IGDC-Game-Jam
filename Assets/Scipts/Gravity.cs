using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gravity : MonoBehaviour
{

    void Update()
    {
        // Check if the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 newGravity = Physics2D.gravity;
            newGravity.y *= -1;
            Physics2D.gravity = newGravity;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Vector2 newGravity = Physics2D.gravity;
            if(newGravity.y > 0 ) newGravity.y *= -1;
            Physics2D.gravity = newGravity;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
