using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step5Trigger : MonoBehaviour
{
    public Animator guardTurn;

    public void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        guardTurn.SetTrigger("Turn");
        Debug.Log(other.name);

    }
}
