using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]

public class TriggerEnterSound : MonoBehaviour
{

  public AudioSource audioSource;
  public AudioClip audioClip1;
	public AudioClip audioClip2;

  void Start()
  {
    if(!audioSource) audioSource = this.GetComponent<AudioSource>();
  }
  
  private void OnTriggerEnter(Collider other)
  {
		if(audioClip1)
			audioSource.PlayOneShot(audioClip1);  
  }

  private void OnTriggerExit(Collider other)
  {
        if (audioClip1)
            audioSource.Stop();
		
		if(audioClip2)
		  audioSource.PlayOneShot(audioClip2);  
  }
}
