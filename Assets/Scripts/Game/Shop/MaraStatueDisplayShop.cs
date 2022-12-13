using UnityEngine;
using UnityEngine.UI;

public class MaraStatueDisplayShop : MonoBehaviour
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
        _currentLvlText.text = (PlayerPrefs.GetInt("maraStatue") + 1).ToString("F0");

        _currentPriceText.text = PlayerPrefs.GetFloat("priceMaraStatue").ToString("F2");
    }
}
