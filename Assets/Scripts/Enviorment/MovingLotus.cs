using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLotus : MonoBehaviour
{
    [SerializeField] float speed;
    void Update()
    {
        transform.position += transform.forward* Time.deltaTime*speed/100;
    }
}
