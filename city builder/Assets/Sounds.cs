using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    private AudioSource audio;
    public AudioClip click;
    public AudioClip build;
    public AudioClip destroy;
    public AudioClip trueAnswer;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlayClick()
    {
        audio.PlayOneShot(click);
    }
    public void PlayBuild()
    {
        audio.PlayOneShot(build);
    }
    public void PlayDestroy()
    {
        audio.PlayOneShot(destroy);
    }
    public void PlayTrueAnswer()
    {
        audio.PlayOneShot(trueAnswer);
    }


}
