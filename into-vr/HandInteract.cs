using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandInteract : MonoBehaviour
{
    //update position/rotation to controller 
        //use tracked pose driver?
    //get when the user pressed the trigger
        //use inputAction or InputActionReference
    //check for overlap

    private SphereCollider _sphere;
    public LayerMask InteractablesMask;
    private void Awake()
    {
        _sphere = GetComponent<SphereCollider>();
    }

    public void IsOverlapping()
    {
        var results = Physics.OverlapSphere(transform.position, _sphere.radius, InteractablesMask);
        foreach (var collider in results)
        {
            Debug.Log($"I am overlapping {collider}");
        }
    }
}
