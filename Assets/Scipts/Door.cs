using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public ButtonDoor button;
    public bool isOpen = false;
    public Gravity gameManager;
    // Start is called before the first frame update
    void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("Game Manager").GetComponent<Gravity>();
        button = GameObject.FindGameObjectWithTag("Button").GetComponent<ButtonDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        if(button != null)
        isOpen = button.isPresssed;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && isOpen)
        {
            Debug.Log("Next Level");
            gameManager.LoadNextScene();
        }
            
    }
}
