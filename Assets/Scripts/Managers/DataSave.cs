using UnityEngine;

public class DataSave : MonoBehaviour
{
    [SerializeField] private float _initialPriceHous;
    [SerializeField] private float _initialPriceFeeder;
    [SerializeField] private float _initialPriceFence;
    [SerializeField] private float _initialPriceMaraStatue;
    [SerializeField] private float _initialPriceGoose;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("hous"))
        {
            PlayerPrefs.SetInt("hous", 0);
        }
        if (!PlayerPrefs.HasKey("profitHous"))
        {
            PlayerPrefs.SetFloat("profitHous", 0);
        } 
        if (!PlayerPrefs.HasKey("priceHous"))
        {
            PlayerPrefs.SetFloat("priceHous", _initialPriceHous);
        }
        

        if (!PlayerPrefs.HasKey("priceFeeder"))
        {
            PlayerPrefs.SetFloat("priceFeeder", _initialPriceFeeder);
        } 
        if (!PlayerPrefs.HasKey("priceFence"))
        {
            PlayerPrefs.SetFloat("priceFence", _initialPriceFence);
        } 
        if (!PlayerPrefs.HasKey("priceMaraStatue"))
        {
            PlayerPrefs.SetFloat("priceMaraStatue", _initialPriceMaraStatue);
        }
        if (!PlayerPrefs.HasKey("priceGoose"))
        {
            PlayerPrefs.SetFloat("priceGoose", _initialPriceGoose);
        }







        if (!PlayerPrefs.HasKey("egg"))
        {
            PlayerPrefs.SetFloat("egg", 0);
        } 
        if (!PlayerPrefs.HasKey("learn"))
        {
            PlayerPrefs.SetInt("learn", 0);
        }
        if (!PlayerPrefs.HasKey("goose"))
        {
            PlayerPrefs.SetInt("goose", 1);
        } 
 
        if (!PlayerPrefs.HasKey("autoclick"))
        {
            PlayerPrefs.SetFloat("autoclick", 1);
        }
    }

    public void DellKeys()
    {
        PlayerPrefs.DeleteAll();
    }

    public void SaveDate()
    {
        PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg"));
    }
}
