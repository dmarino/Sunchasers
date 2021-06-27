using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionAnswer : Answer
{
    [SerializeField] public QuestionnaireInfo.EMOTIONS _Emotion;

    private void Awake()
    {
        _Label.text = _Emotion.ToString();
         _Label.gameObject.SetActive(false);
    }

    public override void WasSelected()
    {
        base.WasSelected();
        QuestionnaireController.Instance.SetEmotion(_Emotion);
    }
}
