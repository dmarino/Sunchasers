using UnityEngine;
using UnityEngine.InputSystem;

public class ControllersListener : MonoBehaviour
{
    #region Singleton
    public static ControllersListener Instance;
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

    [HideInInspector] public Vector3 LeftPos;
    [HideInInspector] public Vector3 RightPos;
    private void AfterAwake()
    {

    }

    public void OnLeftMovement(InputAction.CallbackContext context)
    {
        
        if(context.started)
        {
            Debug.Log(LeftPos);

            Vector3 pos = context.ReadValue<Vector3>();
            if(pos==null){ return;}

            LeftPos = pos;
        }
    }

    public void OnRightMovement(InputAction.CallbackContext context)
    {
        Debug.Log("entra");
        if(context.started)
        {
            Vector3 pos = context.ReadValue<Vector3>();
            if(pos==null){ return;}

            RightPos = pos;
        }
    }
}
