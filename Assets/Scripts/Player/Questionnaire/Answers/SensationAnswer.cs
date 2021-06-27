using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensationAnswer : Answer
{

    [SerializeField] public QuestionnaireInfo.SENSATION _Sensation;

    private void Awake()
    {
        _Label.text = _Sensation.ToString();
    }
    
    public override void WasSelected()
    {
        base.WasSelected();
        QuestionnaireController.Instance.SetSensation(_Sensation);
    }
}
