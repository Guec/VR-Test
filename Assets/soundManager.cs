using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip1;

    // Start is called before the first frame update
    void Start()
    {
        Play();
    }

    // Update is called once per frame
    void Play()
    {
        source.PlayOneShot(clip1);
        print("played");
    }
}
