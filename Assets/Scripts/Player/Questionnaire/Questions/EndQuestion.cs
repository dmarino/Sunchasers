using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndQuestion : MonoBehaviour, Question
{
    public GameObject GO => gameObject;

    public void ChangeTo(string nextQuestion)
    {
        gameObject.SetActive(false);
    }
}
