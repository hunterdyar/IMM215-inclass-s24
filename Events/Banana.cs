using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class Banana : MonoBehaviour
{
    private float timer;
    
    //events.
    //unityEvent uses the inspector to set up the events/listeners
    public UnityEvent bananaUnityEvent;
    //action use c# to subscribe and unsubscribe listeners
    public Action bananaAction;
    
    
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {
            BananaEvent();
            timer = Random.Range(0, 2f);
        }
    }
    
    void BananaEvent()
    {
        bananaAction?.Invoke();
        bananaUnityEvent.Invoke();   
    }
}
