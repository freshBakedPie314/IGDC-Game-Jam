using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource BgMusicSource;
    [SerializeField] AudioSource SFXMusicSource;
    public AudioClip BgMusicClip;

    public static AudioManager instance;
    // Start is called before the first frame update

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }   
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        //DontDestroyOnLoad(gameObject);
        BgMusicSource.clip = BgMusicClip;
        BgMusicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudio(AudioClip _clip)
    {
        SFXMusicSource.PlayOneShot(_clip);
    }
}
