using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    
    [HideInInspector] [SerializeField] private Button _maxLevelHous;
    [HideInInspector] [SerializeField] private Hous _hous;
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
            PlayerPrefs.SetFloat("autoclick", PlayerPrefs.GetFloat("autoclick") * _multiplyIncomeBuildings);
            PlayerPrefs.SetFloat("priceHous", PlayerPrefs.GetFloat("priceHous") * _multiplyPriceBuildings);
            UpgradeHous();
        }
    }
}
