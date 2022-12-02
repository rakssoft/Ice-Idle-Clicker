using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HousDisplayShop : MonoBehaviour
{
    [SerializeField] private Text _currentLvlText;
    [SerializeField] private Text _currentProfitText;
    [SerializeField] private Text _currentPriceText;




    private void Start()
    {
        Display();
    }

    public void Display()
    {
        _currentLvlText.text = (PlayerPrefs.GetInt("hous") + 1).ToString("F0");
   
        _currentPriceText.text = PlayerPrefs.GetFloat("priceHous").ToString("F2");
    }
}
