using UnityEngine;
using UnityEngine.Events;

public class AutoClick : MonoBehaviour
{
    
    [SerializeField] private float _timerOutClick;
    private float timerOut;
    public static UnityAction<float> autoclick;


    private void Start()
    {
        timerOut = _timerOutClick;
    }

    private void Update()
    {

        timerOut -= Time.deltaTime;
        if(timerOut <= 0)
        {
            timerOut = _timerOutClick;
            autoclick?.Invoke(PlayerPrefs.GetFloat("autoclick"));
        }
        
    }
}
