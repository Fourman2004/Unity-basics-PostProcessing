using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventAudio_RandomPlay : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioClip;

    [SerializeField] private int interval = 0;
    [SerializeField] private int intervalStep = 0;

    void Start()
    {
        if(!audioSource) audioSource = this.GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void AnimationEvent()
    {
        if(interval == intervalStep)
        {
            AudioEvent1();
            interval = 0;
            intervalStep = Random.Range(1,6); 
        }
        else interval ++;

    }

    void AudioEvent1()
    {
        audioSource.PlayOneShot(audioClip);  
    }


}
