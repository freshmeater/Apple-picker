using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DroppedSoundPlay : MonoBehaviour
{
    public AudioSource audioPlayer;
    void Start()
    {
        AppleDrop.onAppleDrop += PlayAudio;
    }

    private void PlayAudio()
    {
        audioPlayer?.Play();
    }
}