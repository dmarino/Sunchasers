using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionnaireController : MonoBehaviour
{
    #region Singleton
    public static QuestionnaireController Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            AfterAwake();
        }
        else
        {
            Destroy(this);
        }
    }
    #endregion

    private Question _currentQuestion;

    private Dictionary<Type, Question> _questions;
    [SerializeField] QuestionnaireInfo _BeginningInfo;
    [SerializeField] QuestionnaireInfo _LastInfo;
    private QuestionnaireInfo _CurrentInfo;

    private bool _QuestionnaireHasStarted=false;

    private void AfterAwake()
    {
        _questions = new Dictionary<Type, Question>();

        foreach (var screen in GetComponentsInChildren<Question>(true))
        {
            screen.GO.SetActive(false);
            _questions.Add(screen.GetType(), screen);
        }

        _CurrentInfo = _BeginningInfo;
        ShowScreen<StartQuestion>();
    }


    public void ShowScreen<T>() where T : Question
    {
        if (_currentQuestion != null)
        {
            _currentQuestion.ChangeTo(typeof(T).ToString());
        }

        var screenType = typeof(T);
        if (_questions.ContainsKey(screenType) == false)
        {
            return;
        }

        _currentQuestion = _questions[screenType];
        _currentQuestion.GO.SetActive(true);
    }

    //set info
    
    public void StartQuestionnaire()
    {
        if(_QuestionnaireHasStarted==false)
        {
            ShowScreen<SensationQuestion>();
            _QuestionnaireHasStarted=true;
        }
        
    }

    public void SetStress(float pStress)
    {
        _CurrentInfo.StressLevel = pStress;
    }
    
    public void SetSensation(QuestionnaireInfo.SENSATION pSensation)
    {
        _CurrentInfo.Sensation = pSensation;
        ShowScreen<ThoughtsQuestion>();
    }

    public void SetEmotion(QuestionnaireInfo.EMOTIONS pEmotions)
    {
        _CurrentInfo.Emotions= pEmotions;
        ShowScreen<BreathingQuestion>();
    }

    public void SetThoughts(QuestionnaireInfo.THOUGHTS pThoughts)
    {
        _CurrentInfo.Thoughts = pThoughts;
        ShowScreen<EmotionQuestion>();
    }
}
