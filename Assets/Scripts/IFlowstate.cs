using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFlowstate 
{
    void StartState(bool force = false);

    void EndState(bool force = false);


}
