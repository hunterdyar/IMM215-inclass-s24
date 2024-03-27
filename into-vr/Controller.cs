using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
   // public UnityEvent _actionEvent;
    public AmazingInteraction Interaction;
    //public InputAction changeColorAction;

    public InputActionReference changeColorRef;
    private void Awake()
    {
   //     changeColorAction.Enable();
        changeColorRef.action.Enable();
    }

    void Update()
    {
        if (changeColorRef.action.WasPerformedThisFrame())
        {
            Interaction.ChangeCubeColor();
            //_actionEvent.Invoke();
        }
    }
}
