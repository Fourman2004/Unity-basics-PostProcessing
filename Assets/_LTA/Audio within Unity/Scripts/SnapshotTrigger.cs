using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SnapshotTrigger : MonoBehaviour
{

    public AudioMixerSnapshot intSnap;
    public AudioMixerSnapshot extSnap;
    public string tagName =  "Player";


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        if (other.gameObject.tag == tagName)
        {
            Debug.Log("trigger23");

            intSnap.TransitionTo(.01f);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == tagName)
        {
            extSnap.TransitionTo(.01f);

        }
    }
}
