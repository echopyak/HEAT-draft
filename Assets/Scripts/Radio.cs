using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public AudioSource musicSource;
    private float volume = 0.0f;


    
    void Start()
    {
        musicSource = GetComponent<AudioSource>();
    }
    public void OnVolumeChanged(DialInteractable dial)
    {
        float ratio = dial.CurrentAngle / dial.RotationAngleMaximum;
        volume = ratio;
        ChangeVolume();
    }

   private void ChangeVolume()
    {
        musicSource.volume = volume;
    }
    public void StartMusic()
    {
        musicSource.Play();
    }
    public void StopMusic()
    {
        musicSource.Stop();
    }
}

