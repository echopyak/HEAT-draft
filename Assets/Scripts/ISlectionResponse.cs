using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal interface ISlectionResponse
{

    void OnSelect(Transform selection);
    void OnDeselect(Transform selection);
}
