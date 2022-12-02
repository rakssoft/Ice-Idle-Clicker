using UnityEngine;
using UnityEngine.Events;

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
            PlayerPrefs.SetFloat("priceGoose", PlayerPrefs.GetFloat("priceGoose") * _multiplyPriceGoose);
            buyGoose?.Invoke();
        }
    }
}
