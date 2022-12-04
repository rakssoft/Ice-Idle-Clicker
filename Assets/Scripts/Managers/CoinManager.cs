using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    [HideInInspector] [SerializeField] private Text _eggText;
    [HideInInspector] [SerializeField] private Text _eggAutoCLickText;
    [SerializeField] private Text _currentCoosekText;
    [SerializeField] private Text _fragmentsWinterText;
    private float currenteggs;

    private void OnEnable()
    {
        AutoClick.autoclick += RecalEggs;
        InputPlayer.click += RecalEggs;
    }

    private void OnDisable()
    {
        AutoClick.autoclick -= RecalEggs;
        InputPlayer.click -= RecalEggs;
    }
    private void Start()
    {
        ShowNumberEggs();
    }

    private void ShowNumberEggs()
    {
        _eggText.text = PlayerPrefs.GetFloat("egg").ToString("F0");
        _eggAutoCLickText.text = PlayerPrefs.GetFloat("autoclick").ToString("F2");
        _currentCoosekText.text = PlayerPrefs.GetInt("goose").ToString();
        _fragmentsWinterText.text = PlayerPrefs.GetFloat("fragmentswinter").ToString();
    }

    /// <summary>
    /// пересчитывает €йца и отображает текстом
    /// </summary>
    /// <param name="click"></param>
    public void RecalEggs(float click)
    {
        currenteggs = click;
        PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") + currenteggs);
        ShowNumberEggs();
    }


}
