using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineController : MonoBehaviour
{

    [SerializeField] TextMesh Text;

    public enum STATE{beginning, FirstQuestionnair, Game, LastQuestionnair};

    private STATE _state;

    // Start is called before the first frame update
    void Start()
    {
        _state = STATE.beginning;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewState(STATE pState)
    {
        _state = pState;
    }
}
