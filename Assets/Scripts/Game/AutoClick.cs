using UnityEngine;
using UnityEngine.Events;

public class AutoClick : MonoBehaviour
{
    
    [SerializeField] private float _timerOutClick;
    [SerializeField] private float _timerOut;
    private float _autoClick;
    public static UnityAction<float> autoclick;
    private float _buffEvents;

    private void OnEnable()
    {
        BuyGoose.buyGoose += RecalAutoClick;
        Events.GameEventsBuff += BuffEvents;
    }
    private void OnDisable()
    {
        BuyGoose.buyGoose -= RecalAutoClick ;
        Events.GameEventsBuff -= BuffEvents;
    }
    private void Start()
    {
        RecalAutoClick();
        _timerOut = _timerOutClick;
        BuffEvents(1);
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("hous") > 0)
        {
            _timerOut -= Time.deltaTime;
            if (_timerOut <= 0)
            {
                _timerOut = _timerOutClick;
                Events.CanQuest?.Invoke();
                autoclick?.Invoke(_autoClick);
               
            }
        }
    }

    public void RecalAutoClick()
    {

        _autoClick = (PlayerPrefs.GetInt("goose")
            * (1 + PlayerPrefs.GetFloat("profitHous")
            + PlayerPrefs.GetFloat("profitFence")
            + PlayerPrefs.GetFloat("profitFeeder")
            + PlayerPrefs.GetFloat("profitCaftan")
            + PlayerPrefs.GetFloat("profitkokoshnik")))
            * _buffEvents;
        PlayerPrefs.SetFloat("autoclick", _autoClick);
      
    }

  private void BuffEvents(float buff)
    {
        _buffEvents = buff;
        RecalAutoClick();
    }
}
