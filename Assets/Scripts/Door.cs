using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public ButtonDoor button;
    public bool isOpen = false;
    public Gravity gameManager;

    AudioManager audioManager;
    public AudioClip doorOpening;
    public AudioClip doorClosing;
    // Start is called before the first frame update
    void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio Manager").GetComponent<AudioManager>();
        gameManager = GameObject.FindGameObjectWithTag("Game Manager").GetComponent<Gravity>();
        button = GameObject.FindGameObjectWithTag("Button").GetComponent<ButtonDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        if(button != null)
            isOpen = button.isPresssed;

        if(isOpen && GetComponentInChildren<SpriteRenderer>().color == Color.white)
        {
            GetComponentInChildren<SpriteRenderer>().color = Color.black;
            audioManager.PlayAudio(doorOpening);
        }
        else if(!isOpen && GetComponentInChildren<SpriteRenderer>().color == Color.black)
        {
            GetComponentInChildren<SpriteRenderer>().color = Color.white;
            audioManager.PlayAudio(doorClosing);
        }
            
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
