using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GooseDisplayShop : MonoBehaviour
{
    [SerializeField] private Text _currentCountText;

    [SerializeField] private Text _currentPriceText;


    private void OnEnable()
    {
        BuyGoose.buyGoose += Display;
    }
    private void OnDisable()
    {
        BuyGoose.buyGoose -= Display;
    }

    private void Start()
    {
        Display();
    }

    public void Display()
    {
        _currentCountText.text = (PlayerPrefs.GetInt("goose") ).ToString("F0");
        _currentPriceText.text = PlayerPrefs.GetFloat("priceGoose").ToString("F0");
    }
}