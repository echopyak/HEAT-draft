using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungryPassenger : MonoBehaviour
{
    public AudioClip hungryTalk;
    public AudioSource audioS;


    void Hungrypassenger()
    {
        audioS.PlayOneShot(hungryTalk);
    }
}
