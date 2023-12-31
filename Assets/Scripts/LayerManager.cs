using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerManager : MonoBehaviour
{
    [SerializeField] private string[] layers = { "Default", "noColl" };


    private void OnTriggerEnter(Collider other)
    {
        ChangeLayer(other,1); // no coll 
    }

    private void OnTriggerExit(Collider other)
    {
        ChangeLayer(other,0); // default  
    }

    private void ChangeLayer(Collider other, int index)
    {
        other.gameObject.layer = LayerMask.NameToLayer(layers[index]);
    }
}
