using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    [SerializeField] private int _countEggQuest;
    [SerializeField] private GameObject _isComplited;
    [SerializeField] private float _incomeQuest;


    private void Update()
    {
        if(PlayerPrefs.GetFloat("egg") >= _countEggQuest)
        {
            _isComplited.SetActive(true);
        }
        else
        {
            _isComplited.SetActive(false);
        }
    }

    public void QuestIsDone()
    {
        PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - _countEggQuest);
        PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") + _incomeQuest * PlayerPrefs.GetFloat("profitMaraStatue"));
        Events.QuestComlited?.Invoke();
    }

}
