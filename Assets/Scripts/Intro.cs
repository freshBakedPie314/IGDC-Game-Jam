using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    [SerializeField]
    [TextArea(3,10)]
    public List<string> dialogues = new List<string>();
    public Text dialougeText;
    int currentDialog = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TypeText(dialogues[currentDialog]));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(currentDialog+1 < dialogues.Count)
            {
                currentDialog++;
                StopAllCoroutines();
                StartCoroutine(TypeText(dialogues[currentDialog]));
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    IEnumerator TypeText(string sentence)
    {
        dialougeText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialougeText.text+= letter;
            yield return null;
        }
    }
}
