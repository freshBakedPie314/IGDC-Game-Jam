using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonDoor : MonoBehaviour
{
    public bool isPresssed = false;
    public GameObject button;
    Vector3 originalPos;
    AudioManager audioManager;
    public AudioClip buttonPressSound;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = button.transform.position;
        audioManager = GameObject.FindGameObjectWithTag("Audio Manager").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isPresssed && button.transform.position == originalPos)
        {
            Vector3 pos = button.transform.localPosition;
            pos.y -= 0.35f;
            button.transform.localPosition = pos;

            button.GetComponentInChildren<SpriteRenderer>().color = Color.green;

            audioManager.PlayAudio(buttonPressSound);
        }
        else if(!isPresssed && button.transform.position != originalPos)
        {
            button.transform.position = originalPos;
            button.GetComponentInChildren<SpriteRenderer>().color = Color.red;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Here");
        isPresssed = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isPresssed = false;
    }
}
