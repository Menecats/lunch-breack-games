using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudioPitch : MonoBehaviour
{
    public float minPitch = .8f;
    public float maxPitch = 1.2f;

    void Start()
    {
        GetComponent<AudioSource>().pitch = Random.Range(minPitch, maxPitch);
    }
}
