using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource voiceoverSource;
    public AudioSource musicSource;
    public AudioSource effectsSource;
   


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlayVoiceOver(AudioClip clip)
    {
        if (voiceoverSource == null)
        {
            return;

        }
        voiceoverSource.clip = clip;
        voiceoverSource.Play();

    }
    public void StopVoiceOver()
    {
        if (voiceoverSource == null)
        {
            return;

        }
        if (voiceoverSource.isPlaying)
        {
            voiceoverSource.Stop();
        }

    }
    public void PlayMusicSource(AudioClip clip)
    {
        if (musicSource == null)
        {
            return;

        }
        musicSource.clip = clip;
        musicSource.Play();

    }
    public void StopMusicSource()
    {
        if (musicSource == null)
        {
            return;

        }
        if (musicSource.isPlaying)
        {
            musicSource.Stop();
        }

    }
    public void PlayEffect(AudioClip clip)
    {
        if (effectsSource == null)
        {
            return;

        }
        effectsSource.clip = clip;
        effectsSource.Play();

    }
    public void StopEffect()
    {
        if (effectsSource == null)
        {
            return;

        }
        if (effectsSource.isPlaying)
        {
            effectsSource.Stop();
        }

    }
}