using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class BreathingListener : MonoBehaviour
{

    [Header("Debug")]
    [SerializeField] float threshold = 0.02f;

    [Header("Debug")]
    [SerializeField] TextMesh BreathingDebug;
    Vector3 LastPos = Vector3.zero;
    public void OnBreathingDetected(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            Vector3 forward = Camera.main.transform.TransformDirection(Vector3.forward);
            Vector3 pos = context.ReadValue<Vector3>();

            BreathingDebug.text = $"Breathing: /n x: {pos.x}  /n z: {pos.z}";
            
           

            LastPos = pos;
        }
        
    }
}
