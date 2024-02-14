using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]

public class ScatterSound : MonoBehaviour
{
    public AudioClip[] audioClip;
    AudioSource audioSource;

    public Vector3 scatterLimitsMin = new Vector3(-10,0,-10);
    public Vector3 scatterLimitsMax = new Vector3(10, 10, 10);

    public Vector2 randomInterval = new Vector2(2,5);

    public Vector2 randomPitch = new Vector2(1, 1);
    public Vector2 randomVol = new Vector2(1, 1);
    public Vector2 randomDistance = new Vector2(500, 500);



    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {

        yield return new WaitForSeconds(Random.Range(randomInterval.x, randomInterval.y));

        if (!audioSource.isPlaying)
        {
            Vector3 pos;
            pos = new Vector3(Random.Range(scatterLimitsMin.x, scatterLimitsMax.x), Random.Range(scatterLimitsMin.y, scatterLimitsMax.y), Random.Range(scatterLimitsMin.z, scatterLimitsMax.z));
            this.transform.position = pos;


            audioSource.pitch = Random.Range(randomPitch.x, randomPitch.y);
            audioSource.maxDistance = Random.Range(randomDistance.x, randomDistance.y);


            int i = Random.Range(0, audioClip.Length);
            audioSource.PlayOneShot(audioClip[i], Random.Range(randomVol.x, randomVol.y));

        }

        StartCoroutine(Delay());

    }

}
