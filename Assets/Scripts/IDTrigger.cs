using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IDTrigger : MonoBehaviour
{
    
    public Transform parentHand;
    public UnityEvent OnID;
    public UnityEvent OnLetter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "IDCard")
        {
            other.transform.SetParent(parentHand);
            OnID?.Invoke();
        }

        if (other.tag == "Letter")
        {
            other.transform.SetParent(parentHand);
            OnLetter?.Invoke();
        }
    }

}