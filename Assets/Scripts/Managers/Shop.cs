using System;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    
    [HideInInspector] [SerializeField] private Button _maxLevelHous;
    [HideInInspector] [SerializeField] private Hous _hous;
    [SerializeField] private AutoClick _autoClick;
    [SerializeField] private HousDisplayShop _housDisplayShop;
    [SerializeField] private float _multiplyPriceBuildings;
    [SerializeField] private float _multiplyIncomeBuildings;





    private void Start()
    {
        UpgradeHous();
    }
    public void UpgradeHous()
    {
        _hous.UpgradeHous();
        _housDisplayShop.Display();

    }

    /// <summary>
    /// Стоимость дома настраивается в DataSave и здесь также идет настройка и умножение
    /// цены за апгрейд дома и умножается его автоклик (он суммируется)
    /// </summary>
    public void BuyUpgradeHous()
    {
        if (PlayerPrefs.GetFloat("egg") >= PlayerPrefs.GetFloat("priceHous"))
        {
            PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - PlayerPrefs.GetFloat("priceHous"));
            PlayerPrefs.SetInt("hous", PlayerPrefs.GetInt("hous") + 1);
            _multiplyIncomeBuildings = RecalMultiplyHous();
            PlayerPrefs.SetFloat("profitHous", _multiplyIncomeBuildings);
            _autoClick.RecalAutoClick();
            double v = 50 * Math.Pow(_multiplyPriceBuildings, PlayerPrefs.GetInt("hous") + 1);
            float price = (float)v;           
            PlayerPrefs.SetFloat("priceHous", price);
            UpgradeHous();
        }
    }

    private float RecalMultiplyHous()
    {
        if (PlayerPrefs.GetInt("hous") <= 1)
        {
            _multiplyIncomeBuildings = 0;
        }
        else if (PlayerPrefs.GetInt("hous") == 2)
        {
            _multiplyIncomeBuildings = 0.3f;
        }
        else if ((PlayerPrefs.GetInt("hous") > 2) && (PlayerPrefs.GetInt("hous") < 6))
        {
            _multiplyIncomeBuildings = 0.4f;
        } 
        else if ((PlayerPrefs.GetInt("hous") >= 6) && (PlayerPrefs.GetInt("hous") < 9))
        {
            _multiplyIncomeBuildings = 0.5f;
        } 
        else if ((PlayerPrefs.GetInt("hous") >= 9) && (PlayerPrefs.GetInt("hous") < 12))
        {
            _multiplyIncomeBuildings = 0.6f;
        }
        else if ((PlayerPrefs.GetInt("hous") >= 12) && (PlayerPrefs.GetInt("hous") < 13))
        {
            _multiplyIncomeBuildings = 0.7f;
        }  
        else if ((PlayerPrefs.GetInt("hous") >= 13) && (PlayerPrefs.GetInt("hous") < 15))
        {
            _multiplyIncomeBuildings = 0.8f;
        } 
        else if ((PlayerPrefs.GetInt("hous") >= 15))
        {
            _multiplyIncomeBuildings = 0.9f;
        }
        return _multiplyIncomeBuildings;
    }
}
