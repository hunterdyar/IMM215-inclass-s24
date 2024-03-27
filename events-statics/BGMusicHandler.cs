using System;
using UnityEngine;


public class BGMusicHandler : MonoBehaviour
{

    private void OnEnable()
    {
        GameManager.OnGameStateChange += OnGameStateChange;
    }

    private void OnDisable()
    {
        GameManager.OnGameStateChange -= OnGameStateChange;

    }

    private void OnGameStateChange(GameState newState)
    {
        if (newState == GameState.Dead)
        {
            //playgameover music
        }
    }
}
