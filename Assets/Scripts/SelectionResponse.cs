using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionResponse : MonoBehaviour, ISlectionResponse
{
    public Material selectedMaterial;
    public Material deselectedMaterial;


    public void OnDeselect(Transform selection)
    {
        selection.GetComponent<Renderer>().material = deselectedMaterial;
    }

    public void OnSelect(Transform selection)
    {
        selection.GetComponent<Renderer>().material = selectedMaterial;
    }

    
    
        
    
}
