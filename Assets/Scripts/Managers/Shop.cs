using System;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{

    [HideInInspector] [SerializeField] private Button _maxLevelHous;
    [SerializeField] private Hous _hous;
    [SerializeField] private AutoClick _autoClick;
    [SerializeField] private HousDisplayShop _housDisplayShop;
    [SerializeField] private Text _currentEgg, _currentEgg2;
    [SerializeField] private float _multiplyPriceBuildings;
    [SerializeField] private float _multiplyIncomeBuildings;
    [SerializeField] private Feeder _feeder;
    [SerializeField] private FeederDisplayShop _feederDisplayShop;
    [SerializeField] private MaraStatue _morana;
    [SerializeField] private MaraStatueDisplayShop _moraDisplayShop;
    [SerializeField] private Fence _fence;
    [SerializeField] private FenceDisplayShop _fenceDisplayShop;
    [SerializeField] private GameObject _canBuyShop, _canBuyUpgrade;
    [SerializeField] private GameObject _shopPanel;
    




    private void Start()
    {
        UpgradeHous();
    }

    private void Update()  // заменить
    {
        _currentEgg.text = PlayerPrefs.GetFloat("egg").ToString("F0");
        _currentEgg2.text = PlayerPrefs.GetFloat("egg").ToString("F0");
    }

    public void CanBuy()
    {
        if (PlayerPrefs.GetFloat("egg") >= PlayerPrefs.GetFloat("priceHous") ||
            PlayerPrefs.GetFloat("egg") >= PlayerPrefs.GetFloat("priceMaraStatue") ||
             PlayerPrefs.GetFloat("egg") >= PlayerPrefs.GetFloat("priceFence") ||
             PlayerPrefs.GetFloat("egg") >= PlayerPrefs.GetFloat("priceFeeder"))
        {
            _canBuyShop.SetActive(true);
        }
        else
        {
            _canBuyShop.SetActive(false);
        }

        if (PlayerPrefs.GetFloat("egg") >= PlayerPrefs.GetFloat("priceGoose"))
        {
            _canBuyUpgrade.SetActive(true);
        }
        else
        {
            _canBuyUpgrade.SetActive(false);
        }
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
            if (PlayerPrefs.GetInt("hous") == 6)
            {
                _shopPanel.SetActive(false);       
            }
            else if (PlayerPrefs.GetInt("hous") == 10)
            {
                _shopPanel.SetActive(false);     
            }
            _multiplyIncomeBuildings = RecalMultiplyHous();

            PlayerPrefs.SetFloat("profitHous", _multiplyIncomeBuildings);
            _autoClick.RecalAutoClick();
            double v = 70 * Math.Pow(_multiplyPriceBuildings, PlayerPrefs.GetInt("hous") + 1);
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
        else if ((PlayerPrefs.GetInt("hous") >= 12) && (PlayerPrefs.GetInt("hous") < 14))
        {
            _multiplyIncomeBuildings = 0.7f;
        }  

        else if ((PlayerPrefs.GetInt("hous") >= 14))
        {
            _multiplyIncomeBuildings = 0.8f;
        }
        return _multiplyIncomeBuildings;
    }

    /// <summary>
    /// Для увеличения стоимости от базовой  50 или 500 нужо изменить значение V  и туда вписать значение базовой стоимости совместить с дата сйев
    /// </summary>
    public void BuyUpgradeFeeder()
    {                                    
        if (PlayerPrefs.GetFloat("egg") >= PlayerPrefs.GetFloat("priceFeeder"))
        {
            PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - PlayerPrefs.GetFloat("priceFeeder"));
            PlayerPrefs.SetInt("feeder", PlayerPrefs.GetInt("feeder") + 1);
            if(PlayerPrefs.GetInt("feeder") == 1)
            {
                _shopPanel.SetActive(false);
                Events.AnimFeeder?.Invoke("food_appearance", false);
            }
            else if (PlayerPrefs.GetInt("feeder") == 6)
            {
                _shopPanel.SetActive(false);
                Events.AnimFeeder?.Invoke("food_upgrade1", false);
            }
            else if (PlayerPrefs.GetInt("feeder") == 10)
            {
                _shopPanel.SetActive(false);
                Events.AnimFeeder?.Invoke("food_upgrade2", false);
            }

                _multiplyIncomeBuildings = RecalMultiplyFeeder();
            PlayerPrefs.SetFloat("profitFeeder", _multiplyIncomeBuildings);
            _autoClick.RecalAutoClick();
            double v = 500 * Math.Pow(_multiplyPriceBuildings, PlayerPrefs.GetInt("feeder") + 1);
            float price = (float)v;
            PlayerPrefs.SetFloat("priceFeeder", price);
            UpgradeFeeder();
        }
    }

    public void UpgradeFeeder()
    {
        _feeder.UpgradeFeeder();
        _feederDisplayShop.Display();
    }

    private float RecalMultiplyFeeder()
    {
        if (PlayerPrefs.GetInt("feeder") <= 1)
        {
            _multiplyIncomeBuildings = 0;
        }
        else if (PlayerPrefs.GetInt("feeder") == 2)
        {
            _multiplyIncomeBuildings = 0.3f;
        }
        else if ((PlayerPrefs.GetInt("feeder") > 2) && (PlayerPrefs.GetInt("feeder") < 6))
        {
            _multiplyIncomeBuildings = 0.4f;
        }
        else if ((PlayerPrefs.GetInt("feeder") >= 6) && (PlayerPrefs.GetInt("feeder") < 9))
        {
            _multiplyIncomeBuildings = 0.5f;
        }
        else if ((PlayerPrefs.GetInt("feeder") >= 9) && (PlayerPrefs.GetInt("feeder") < 12))
        {
            _multiplyIncomeBuildings = 0.6f;
        }
        else if ((PlayerPrefs.GetInt("feeder") >= 12) && (PlayerPrefs.GetInt("feeder") < 14))
        {
            _multiplyIncomeBuildings = 0.7f;
        }
        else if ((PlayerPrefs.GetInt("feeder") >= 14))
        {
            _multiplyIncomeBuildings = 0.8f;
        }
        return _multiplyIncomeBuildings;
    }

    public void BuyUpgradeMorana()
    {
        if (PlayerPrefs.GetFloat("fragmentswinter") >= PlayerPrefs.GetFloat("priceMaraStatue"))
        {
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") - PlayerPrefs.GetFloat("priceMaraStatue"));
            PlayerPrefs.SetInt("maraStatue", PlayerPrefs.GetInt("maraStatue") + 1);
            _multiplyIncomeBuildings = RecalMultiplyMarana();
            PlayerPrefs.SetFloat("profitMaraStatue", _multiplyIncomeBuildings);
            _autoClick.RecalAutoClick();
            double v = 500 * Math.Pow(_multiplyPriceBuildings, PlayerPrefs.GetInt("maraStatue") + 1);
            float price = (float)v;
            PlayerPrefs.SetFloat("priceMaraStatue", price);
            UpgradeMarana();
        }
    }

    public void UpgradeMarana()
    {
        _morana.UpgradeMara();
        _moraDisplayShop.Display();
    }

    private float RecalMultiplyMarana()
    {
        string Mara = "maraStatue";
        if (PlayerPrefs.GetInt(Mara) == 0)
        {
            _multiplyIncomeBuildings = 1;
        }
        else if (PlayerPrefs.GetInt(Mara) == 1)
        {
            _multiplyIncomeBuildings = 1.1f;
        }
        else if ((PlayerPrefs.GetInt(Mara) == 2))
        {
            _multiplyIncomeBuildings = 1.2f;
        }

        return _multiplyIncomeBuildings;
    }


    public void BuyUpgradeFence()
    {
        if (PlayerPrefs.GetFloat("egg") >= PlayerPrefs.GetFloat("priceFence"))
        {
            PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - PlayerPrefs.GetFloat("priceFence"));
            PlayerPrefs.SetInt("fence", PlayerPrefs.GetInt("fence") + 1);
            if (PlayerPrefs.GetInt("fence") == 1)
            {
                _shopPanel.SetActive(false);
                Events.AnimFence?.Invoke("fence_appearance", false);
            }
            else if (PlayerPrefs.GetInt("fence") == 6)
            {
                _shopPanel.SetActive(false);
                Events.AnimFence?.Invoke("fence_upgrade_1", false);
            }
            else if (PlayerPrefs.GetInt("fence") == 10)
            {
                _shopPanel.SetActive(false);
                Events.AnimFence?.Invoke("fence_upgrade_2", false);
            }
            _multiplyIncomeBuildings = RecalMultiplyFence();
            PlayerPrefs.SetFloat("profitFence", _multiplyIncomeBuildings);
            _autoClick.RecalAutoClick();
            double v = 2000 * Math.Pow(_multiplyPriceBuildings, PlayerPrefs.GetInt("fence") + 1);
            float price = (float)v;
            PlayerPrefs.SetFloat("priceFence", price);
            UpgradeFence();
        }
    }

    public void UpgradeFence()
    {
        _fence.UpgradeFence();
        _fenceDisplayShop.Display();
    }

    private float RecalMultiplyFence()
    {
        string fence = "fence";
        if (PlayerPrefs.GetInt(fence) <= 1)
        {
            _multiplyIncomeBuildings = 0;
        }
        else if (PlayerPrefs.GetInt(fence) == 2)
        {
            _multiplyIncomeBuildings = 0.3f;
        }
        else if ((PlayerPrefs.GetInt(fence) > 2) && (PlayerPrefs.GetInt(fence) < 6))
        {
            _multiplyIncomeBuildings = 0.4f;
        }
        else if ((PlayerPrefs.GetInt(fence) >= 6) && (PlayerPrefs.GetInt(fence) < 9))
        {
            _multiplyIncomeBuildings = 0.5f;
        }
        else if ((PlayerPrefs.GetInt(fence) >= 9) && (PlayerPrefs.GetInt(fence) < 12))
        {
            _multiplyIncomeBuildings = 0.6f;
        }
        else if ((PlayerPrefs.GetInt(fence) >= 12) && (PlayerPrefs.GetInt(fence) < 14))
        {
            _multiplyIncomeBuildings = 0.7f;
        }
        else if ((PlayerPrefs.GetInt(fence) >= 14))
        {
            _multiplyIncomeBuildings = 0.8f;
        }
        return _multiplyIncomeBuildings;
    }
}
