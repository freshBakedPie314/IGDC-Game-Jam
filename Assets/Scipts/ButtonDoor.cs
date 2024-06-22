using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonDoor : MonoBehaviour
{
    public bool isPresssed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Here");
        isPresssed = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isPresssed = false;
    }
}
