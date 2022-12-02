using UnityEngine;
using UnityEngine.Events;

public class AutoClick : MonoBehaviour
{
    
    [SerializeField] private float _timerOutClick;
    private float _timerOut;
    private float _autoClick;
    public static UnityAction<float> autoclick;

    private void OnEnable()
    {
        BuyGoose.buyGoose += RecalAutoClick;
    }
    private void OnDisable()
    {
        BuyGoose.buyGoose -= RecalAutoClick ;
    }
    private void Start()
    {
        _timerOut = _timerOutClick;
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("hous") > 0)
        {
            _timerOut -= Time.deltaTime;
            if (_timerOut <= 0)
            {
                _timerOut = _timerOutClick;
                autoclick?.Invoke(_autoClick);
            }
        }
 
    }

    public void RecalAutoClick()
    {
        _autoClick = PlayerPrefs.GetInt("goose") * (1 + PlayerPrefs.GetFloat("profitHous") + PlayerPrefs.GetFloat("profitFence", 0) + PlayerPrefs.GetFloat("profitFeeder"));
        PlayerPrefs.SetFloat("autoclick", _autoClick);
      
    }
}
