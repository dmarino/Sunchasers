using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Question
{
    GameObject GO { get; }
    void ChangeTo(string nextQuestion);
}
