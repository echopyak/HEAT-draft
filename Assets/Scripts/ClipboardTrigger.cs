using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipboardTrigger : MonoBehaviour
{

    public Transform parentHandLetter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Letter")
        {
            other.transform.SetParent(parentHandLetter);
        }
    }

}