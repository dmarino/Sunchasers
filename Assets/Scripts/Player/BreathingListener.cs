using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class BreathingListener : MonoBehaviour
{
    #region Singleton
    public static BreathingListener Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            AfterAwake();
        }
        else
        {
            Destroy(this);
        }
    }
    #endregion

    //singleton variables
    public float intensity=0;

    [Header("Debug")]
    [SerializeField] TextMesh BreathingDebug;

    //for internal use
    private Vector3 OriginalPosition = Vector3.zero;
    private Vector3 LastPosition = Vector3.zero;

    private float LastDistance =0f;
    private float MaxDistance =0f;

    private void AfterAwake()
    {

    }

    public void OnBreathingDetected(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            //here i get the pos of the controller and i do a nullcheck
            Vector3 pos = context.ReadValue<Vector3>();
            if(pos==null){ return;}

            //check the distance from the breath in position to the breath out position (?)
            float distance = Vector3.Distance(OriginalPosition, pos);
            if(distance > MaxDistance)
            {
                MaxDistance =distance;
            }

            //show the remmaped value
            intensity = distance;
            BreathingDebug.text = $"Intensity: {ReMap(0,4)}";

            LastPosition = pos;
            LastDistance = distance;
        }
       
        
    }

    public void Testing(InputAction.CallbackContext context)
    {
        OriginalPosition = LastPosition;
        MaxDistance = 0f;
    }


    public float ReMap(float newMin, float newMax)
    {
        return Mathf.Lerp (newMin, newMax, Mathf.InverseLerp (0,MaxDistance, intensity));
    }
}
