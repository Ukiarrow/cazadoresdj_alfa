using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {

    public AudioClip levelExMusic;

    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    /*
    void OnLevelWasLoaded()
    {
        if (extra == true)
        {
            source.clip = levelExMusic;
            source.Play();
        }
    }
    */
}
