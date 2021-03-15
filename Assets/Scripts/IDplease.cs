using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDplease : MonoBehaviour
{
    public AudioClip idAsk;
    public AudioSource audioS;


    void IDDemand()
    {
        audioS.PlayOneShot(idAsk);
    }
}
