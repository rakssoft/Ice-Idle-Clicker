using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    [SerializeField] private int _requestQuest;
    [SerializeField] private GameObject _isComplitedButton;
    [SerializeField] private float _incomeQuest;


 
    public void QuestHomeIsComplited()
    {

    }

    public void QuestIsDoneMorana()
    {
        PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - _requestQuest);
        PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") + _incomeQuest * PlayerPrefs.GetFloat("profitMaraStatue"));
        Events.QuestComlited?.Invoke();
    }

}
