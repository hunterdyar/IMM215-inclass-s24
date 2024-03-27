using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Action<GameState> OnGameStateChange;
    private GameState _state;

    //a less weird getter function than the expression-bodied thing.
    public GameState GetGameState()
    {
        return _state;
    }
    public void Start()
    {
        ChangeGameState(GameState.Init);
    }

    public void PlayerDied()
    {
        ChangeGameState(GameState.Dead);
    }

    private void ChangeGameState(GameState newState)
    {
        _state = newState;
        OnGameStateChange?.Invoke(_state);
    }
}