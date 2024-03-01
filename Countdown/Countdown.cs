using UnityEngine;

public class Countdown
{
     private float _timer;
     private float _lastCountdownTime;
     public void Init(float countdownTime)
     {
          if (countdownTime <= 0)
          {
               Debug.LogWarning("There is no time to countdown. This is a bad amount of time for countdown time.");
          }
          _lastCountdownTime = countdownTime;
          _timer = countdownTime;
     }

     public void Reset()
     {
          _timer = _lastCountdownTime;
     }
     
     public void Tick(float delta)
     {
          _timer = _timer - delta;
     }

     public bool IsDone()
     {
          return _timer <= 0;
     }
}