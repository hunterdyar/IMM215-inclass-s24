using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Hop : MonoBehaviour
{
    public float range = 5f;
    public Banana banana;

    private void OnEnable()
    {
        banana.bananaAction += DoHop;
    }
    private void OnDisable()
    {
        banana.bananaAction -= DoHop;
    }


    private void DoHop()
    {
        transform.position = transform.position + Random.insideUnitSphere*range;
    }
}
