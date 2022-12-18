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
        float number = PlayerPrefs.GetFloat("profitMaraStatue");
        if(number == 1)
        {
            number = 10;
        }
        else if(number == 1.1)
        {
            number = 20;
        }
        else if(number == 1.2)
        {
            number = 20;
        }
        _currentProfitText.text = number.ToString();
        _currentPriceText.text = PlayerPrefs.GetFloat("priceMaraStatue").ToString("F0");
    }
}
