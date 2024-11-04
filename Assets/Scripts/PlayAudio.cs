using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{

    public AudioSource audioSource;
    
    //  void Start()
    // {
    //     PlayAudioSource();
    // }

    public void PlayAudioSource(AudioSource audioSource)
    {
        // Check if the audio is not already playing before calling Play
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
        
}
