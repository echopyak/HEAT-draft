using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTriggerState : FlowBaseState
{

    private bool enable = false;

    private void OnEnable()
    {

    }
    public override void StartState(bool force = false)
    {
        base.StartState(force);
        enable = true;
    }

    public override void EndState(bool force = false)
    {
        base.EndState(force);
        enable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!AudioManager.instance.voiceoverSource.isPlaying && enable == true)
        {
            OnAudioEnd();
        }

    }
    public void OnAudioEnd()
    {
        NextState();
    }
}
