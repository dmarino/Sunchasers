using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleScale : MonoBehaviour
{

    [SerializeField] int MinSize=0;
    [SerializeField] int MaxSize=2;
    // Update is called once per frame
    void Update()
    {
        float scale = BreathingListener.Instance.ReMap(MinSize,MaxSize); 
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
