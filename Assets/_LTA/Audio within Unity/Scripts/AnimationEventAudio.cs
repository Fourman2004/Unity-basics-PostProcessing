using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventAudio : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioClip;


    // Start is called before the first frame update
    void AudioEvent1()
    {
        audioSource.PlayOneShot(audioClip);  
    }


}
