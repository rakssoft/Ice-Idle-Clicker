using UnityEngine;
using UnityEngine.Events;

public class BuyGoose : MonoBehaviour
{
    [SerializeField] private float _multiplyPriceGoose;

    public static UnityAction<int> coutnGoose;
    public void BuyGooses()
    {
        if (PlayerPrefs.GetFloat("egg") >= PlayerPrefs.GetFloat("priceGoose"))
        {
            PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - PlayerPrefs.GetFloat("priceGoose"));
            PlayerPrefs.SetInt("goose", PlayerPrefs.GetInt("goose") + 1);
            PlayerPrefs.SetFloat("autoclick", PlayerPrefs.GetFloat("autoclick") + 1);
            PlayerPrefs.SetFloat("priceGoose", PlayerPrefs.GetFloat("priceGoose") * _multiplyPriceGoose);
            coutnGoose?.Invoke(PlayerPrefs.GetInt("goose"));
        }
    }
}
