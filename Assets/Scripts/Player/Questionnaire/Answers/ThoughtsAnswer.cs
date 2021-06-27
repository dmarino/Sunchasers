using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThoughtsAnswer : Answer
{
    [SerializeField] public QuestionnaireInfo.THOUGHTS _Thoughts;

    private void Awake()
    {
        _Label.text = _Thoughts.ToString();
         _Label.gameObject.SetActive(false);
    }

    public override void WasSelected()
    {
        base.WasSelected();
        QuestionnaireController.Instance.SetThoughts(_Thoughts);
    }
}
