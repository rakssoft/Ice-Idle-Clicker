
using UnityEngine;
using UnityEngine.UI;

public class Quests : MonoBehaviour
{
    [SerializeField] private GameObject[] _questComplitedButton;
    [SerializeField] private GameObject[] lockImage;
    [SerializeField] private GameObject[] _isComplitedText;
    [SerializeField] private GameObject _buttonMaranaQuest;
    private int _idQuest;
    private float _timerQuest;
    private bool _beginTimer;

    private void OnEnable()
    {
        Events.QuestComlited += ShowQuest;
        Events.QuestComlited += IsDoneQuest;
        
    }
    private void OnDisable()
    {
        Events.QuestComlited -= ShowQuest;
        Events.QuestComlited -= IsDoneQuest;
    }
    private void Start()
    {
        _timerQuest = 30f;
        _beginTimer = false;
        ShowQuest();
    }

    private void Update()
    {
        if(_beginTimer == true)
        {
            _timerQuest -= Time.deltaTime;
            if (_timerQuest <= 0)
            {
                _buttonMaranaQuest.SetActive(true);
            }
        }
       

    }

    public void ShowQuest()
    {
        _idQuest = PlayerPrefs.GetInt("quest");
        for (int i = 0; i < lockImage.Length; i++)
        {
            lockImage[i].SetActive(true);
            if(i < _idQuest)
            {
                _isComplitedText[i].SetActive(true);
                 lockImage[i].SetActive(false);
                _questComplitedButton[i].SetActive(false);
             
            }
        }
        lockImage[_idQuest].SetActive(false);
    }

    public void IsDoneQuest()
    {
        _beginTimer = true;
    }

    public void BeginNewQuest()
    {
        _beginTimer = false;

           PlayerPrefs.SetInt("quest",  PlayerPrefs.GetInt("quest") + 1);
    }
}
