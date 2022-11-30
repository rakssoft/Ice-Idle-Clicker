using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private Text _eggText;
    [SerializeField] private Text _eggAutoCLickText;
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
