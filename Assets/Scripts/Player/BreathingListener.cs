using System.Collections;
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

    //Variables that can be accesibly to everyone
    [HideInInspector] public float Intensity=0;
    public int _AmountOfBreatOuts;

    [Header("SetUo")]
    [SerializeField] int SecondsBreatheIn=4;
    [SerializeField] GameObject LotusPrefab;

    [SerializeField] Transform LotusSpawnPoint;

    [Header("Debug")]
    [SerializeField] TextMesh BreathingDebug;

    //for internal use
    private Vector3 OriginalPosition = Vector3.zero;
    private Vector3 LastPosition = Vector3.zero;

    private float LastIntensity =0f;
    private float MaxIntensity =0f;
    private bool _HasGameStarted;




    private void AfterAwake()
    {
        _HasGameStarted=false;
    }


    private void Update()
    {
        if( _HasGameStarted)
        {
            Debug.Log(Intensity);

            Vector3 pos = ControllersListener.Instance.LeftPos;
            Intensity= Vector3.Distance(OriginalPosition, pos);
            LastPosition = pos;
        }
    }

    public void OnBreathingDetected(InputAction.CallbackContext context)
    {
        if( _HasGameStarted && context.started)
        {
            Debug.Log(Intensity);
            
            //here i get the pos of the controller and i do a nullcheck
            Vector3 pos = context.ReadValue<Vector3>();
            if(pos==null){ return;}

            //check the distance from the breath in position to the breath out position (?)
            Intensity= Vector3.Distance(OriginalPosition, pos);
            LastPosition = pos;

            if(Intensity >= MaxIntensity)
            {
                _AmountOfBreatOuts ++;
                Instantiate(LotusPrefab, LotusSpawnPoint.position, Random.rotation);

            }


        }
       
    }

    public void Testing()
    {
        if(_HasGameStarted==false)
        {
            _HasGameStarted = true;
            StartCoroutine(SetUp());
        }

    }


    public float ReMap(float newMin, float newMax)
    {
        return Mathf.Lerp (newMin, newMax, Mathf.InverseLerp (0,MaxIntensity, Intensity));
    }


    IEnumerator SetUp() 
    {
        MaxIntensity = 0;

        float tempTime=0f;
        while(tempTime < SecondsBreatheIn)
        {
            BreathingDebug.text = "Breathe in";
            if(LastPosition.magnitude < OriginalPosition.magnitude)
            {
                OriginalPosition = LastPosition;
            }

            tempTime += 0.1f;
            yield return new WaitForSeconds(.1f);
        }

        tempTime=0f;
        
        while(tempTime < SecondsBreatheIn)
        {
            BreathingDebug.text = "Breathe out";
            if(Intensity > MaxIntensity)
            {
                MaxIntensity= Intensity;
            }

            tempTime += 0.1f;
            yield return new WaitForSeconds(.1f);
        }
        
        BreathingDebug.text="";

        QuestionnaireController.Instance.ShowScreen<GameQuestion>();
    }
}
