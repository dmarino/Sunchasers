using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensationAnswer : Answer
{

    [SerializeField] QuestionnaireController _controller;
    [SerializeField] public QuestionnaireInfo.SENSATION _Sensation;

    private void Awake()
    {
        _Label.text = _Sensation.ToString();
    }


    public override void WasSelected()
    {
        base.WasSelected();
        _controller.SetSensation(_Sensation);
    }
}
