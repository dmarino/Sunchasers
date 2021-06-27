using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathingQuestion : MonoBehaviour, Question
{
    public GameObject GO => gameObject;

    private void OnEnable()
    {
        BreathingListener.Instance.Testing();
    }
    public void ChangeTo(string nextQuestion)
    {
        gameObject.SetActive(false);
    }
}
