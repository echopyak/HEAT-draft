using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTriggerState : FlowBaseState
{
    public void OnTrigger()
    {
        NextState();
    }

    public override void StartState(bool force = false)
    {
        base.StartState(force);
        
    }

    public override void EndState(bool force = false)
    {
        base.EndState(force);
        
    }

}
