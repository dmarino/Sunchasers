using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public float StressLevel;

    public enum Sensation{Tense, Racing, Heavy, Rested, Energised, Restless, Relaxed}

    public enum Thoughts{Rapid, Critical, Confused, Obsessive, Stuck, Empty, Vague}

    public enum Emotions{Happy, Surprised, Bad, Fearful, Angry, Disgusted, Sad, Calm}
}
