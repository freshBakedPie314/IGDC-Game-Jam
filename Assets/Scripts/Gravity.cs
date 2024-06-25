using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gravity : MonoBehaviour
{
    List<Conveyor> conveyors = new List<Conveyor>();

    void Start()
    {
        GameObject[] go = GameObject.FindGameObjectsWithTag("Conveyor");
        foreach (GameObject go2 in go)
        {
            conveyors.Add(go2.GetComponent<Conveyor>());
        }
    }
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


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            foreach(Conveyor conveyor in conveyors)
            {
                conveyor.switchDir();
            }
        }
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
