using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CatchedSoundPlay : MonoBehaviour
{
    public AudioSource audioPlayer;
    void Start()
    {
        BasketDestroyApples.onAppleCatched += PlayAudio;
    }

    private void PlayAudio()
    {
        audioPlayer?.Play();
    }
}
