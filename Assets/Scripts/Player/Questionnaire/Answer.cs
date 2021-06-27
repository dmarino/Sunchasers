using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Answer: MonoBehaviour
{
    [SerializeField] public TextMesh _Label;
    public virtual void WasSelected(){}
}
