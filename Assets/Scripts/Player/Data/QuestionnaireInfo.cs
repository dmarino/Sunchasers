using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/Questionnaire/Info")]
public class QuestionnaireInfo: ScriptableObject
{
    public float StressLevel;

    public enum SENSATION{Tense, Racing, Heavy, Rested, Energised, Restless, Relaxed}
    public SENSATION Sensation;

    public enum THOUGHTS{Rapid, Critical, Confused, Obsessive, Stuck, Empty, Vague}
    public THOUGHTS Thoughts;

    public enum EMOTIONS{Happy, Surprised, Bad, Fearful, Angry, Disgusted, Sad, Calm}
    public EMOTIONS Emotions;
}
