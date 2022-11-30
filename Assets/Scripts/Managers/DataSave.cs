using UnityEngine;

public class DataSave : MonoBehaviour
{
    [SerializeField] private float _priceHous;
    [SerializeField] private float _priceFeeder;
    [SerializeField] private float _priceFence;
    [SerializeField] private float _priceMaraStatue;
    [SerializeField] private float _priceGoose;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("priceHous"))
        {
            PlayerPrefs.SetFloat("priceHous", _priceHous);
        } 
        if (!PlayerPrefs.HasKey("priceFeeder"))
        {
            PlayerPrefs.SetFloat("priceFeeder", _priceFeeder);
        } 
        if (!PlayerPrefs.HasKey("priceFence"))
        {
            PlayerPrefs.SetFloat("priceFence", _priceFence);
        } 
        if (!PlayerPrefs.HasKey("priceMaraStatue"))
        {
            PlayerPrefs.SetFloat("priceMaraStatue", _priceMaraStatue);
        }
        if (!PlayerPrefs.HasKey("priceGoose"))
        {
            PlayerPrefs.SetFloat("priceGoose", _priceGoose);
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
        if (!PlayerPrefs.HasKey("hous"))
        {
            PlayerPrefs.SetInt("hous", 0);
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
