using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleScale : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        float scale = BreathingListener.Instance.ReMap(0,2); 
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
