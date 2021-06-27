using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionnaireController : MonoBehaviour
{
    public enum QUESTION{none, Stress, Sensation, thoughts, emotion}
    private QUESTION _question;

    [SerializeField] private GameObject StressQuestion;


    public void StartQuestionnaire()
    {
        _question = QUESTION.Stress;
        StressQuestion.SetActive(true);
    }


    //set info
    [SerializeField] QuestionnaireInfo _CurrentInfo;
    public void SetSensation(QuestionnaireInfo.SENSATION pSensation)
    {
        _CurrentInfo.Sensation = pSensation;
    }

    public void SetEmotion(QuestionnaireInfo.EMOTIONS pEmotions)
    {
        _CurrentInfo.Emotions= pEmotions;
    }

    public void SetThoughts(QuestionnaireInfo.THOUGHTS pThoughts)
    {
        _CurrentInfo.Thoughts = pThoughts;
    }
}
