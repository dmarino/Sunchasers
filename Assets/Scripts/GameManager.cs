using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public enum STATE{beginning, FirstQuestionnair, Game, LastQuestionnair};
    private STATE _state;

    

    private void Awake()
    {
        _state = STATE.beginning;
    }

    public void MainButtonPressed(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            _state = STATE.FirstQuestionnair;
        }
    }
}
