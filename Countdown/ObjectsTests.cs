using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObjectsTests : MonoBehaviour
{
    private Countdown _finalCountdown;
    
    void Start()
    {
        Debug.Log("Start");
        _finalCountdown = new Countdown();
        _finalCountdown.Init(3);
    }
    private void Update()
    {
        _finalCountdown.Tick(Time.deltaTime);
        
       
        if (_finalCountdown.IsDone())
        {
            _finalCountdown.Reset();
            DoAThing();
        }
    }

    private void DoAThing()
    {
        Debug.Log("dO a tHING");
    }

}
