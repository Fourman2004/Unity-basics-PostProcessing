using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class CollisionEnterSound : MonoBehaviour
{

    public AudioClip hitSound;
    public AudioClip movementSound;
    AudioSource audioSource;
    public Vector2 pitchShift = new Vector2(1,1);

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        var pitchshift = Random.Range(pitchShift.x, pitchShift.y);
        audioSource.pitch = pitchshift;
        audioSource.loop = false;


        audioSource.PlayOneShot(hitSound, 1f);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(movementSound);
            audioSource.pitch = .59f;
            audioSource.loop = true;
        }

    }

}
