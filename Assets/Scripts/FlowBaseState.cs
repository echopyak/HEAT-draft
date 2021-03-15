using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FlowBaseState : MonoBehaviour, IFlowstate

{
    public AudioClip voiceOverClip;
    public AudioClip musicClip;
    public AudioClip effectsClip;
    public float audioDelay;
    public float nextStateDelay;
    public bool movingToNextState = false;
    [SerializeField]
    private UnityEvent onStartState;
    [SerializeField]
    private UnityEvent onEndState;



    public virtual void StartState(bool force = false)
    {
        if (voiceOverClip)
        {
            StartCoroutine(PlayVoiceOverDelay(audioDelay, voiceOverClip));
        }
        onStartState?.Invoke();
    }

    public virtual void EndState(bool force = false)
    {
        if (voiceOverClip)
        {
            AudioManager.instance.StopVoiceOver();
            AudioManager.instance.StopMusicSource();
            AudioManager.instance.StopEffect();

        }
        onEndState?.Invoke();
       
    }

    public virtual void NextState()
    {
        if (!movingToNextState)
        {
            FlowStateHandler.instance.NextState(nextStateDelay);
        }
        movingToNextState = true;
    }
    public virtual void PlayVoiceOver()
    {
        StartCoroutine(PlayVoiceOverDelay(audioDelay, voiceOverClip));
    }

    public virtual void PlayMusic()
    {
        StartCoroutine(PlayMusicDelay(audioDelay, musicClip));
    }

    public virtual void PlayEffect()
    {
        StartCoroutine(PlayEffectDelay(audioDelay, effectsClip));
    }

    private IEnumerator PlayVoiceOverDelay(float delay, AudioClip clip)
    {
        yield return new WaitForSeconds(delay);
        AudioManager.instance.PlayVoiceOver(clip);
        
    }

    private IEnumerator PlayMusicDelay(float delay, AudioClip clip)
    {
        yield return new WaitForSeconds(delay);
        AudioManager.instance.PlayMusicSource(clip);
        
    }

    private IEnumerator PlayEffectDelay(float delay, AudioClip clip)
    {
        yield return new WaitForSeconds(delay);
        AudioManager.instance.PlayEffect(clip);
    }
}