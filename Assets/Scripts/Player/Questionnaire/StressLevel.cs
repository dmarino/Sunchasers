using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StressLevel : MonoBehaviour
{
    [SerializeField] TextMesh DebugMesh;


    void Update()
    {
        float distance = Vector3.Distance(ControllersListener.Instance.RightPos, ControllersListener.Instance.LeftPos);
        DebugMesh.text = $"{ControllersListener.Instance.RightPos}";    
    }
}
