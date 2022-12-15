using UnityEngine;
using UnityEngine.Events;
using System;

public class BuyGoose : MonoBehaviour
{
    [SerializeField] private float _multiplyPriceGoose;

    public static UnityAction buyGoose;
    public void BuyGooses()
    {
        if (PlayerPrefs.GetFloat("egg") >= PlayerPrefs.GetFloat("priceGoose"))
        {
            PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - PlayerPrefs.GetFloat("priceGoose"));
            PlayerPrefs.SetInt("goose", PlayerPrefs.GetInt("goose") + 1);
            double v = 50 * Math.Pow(_multiplyPriceGoose, PlayerPrefs.GetInt("goose") + 1);
            float price = (float)v;
            PlayerPrefs.SetFloat("priceGoose", price);
            buyGoose?.Invoke();
        }
    }
}
