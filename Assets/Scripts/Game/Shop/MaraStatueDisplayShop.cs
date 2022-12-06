using UnityEngine;
using UnityEngine.UI;

public class MaraStatueDisplayShop : MonoBehaviour
{
    [SerializeField] private Text _currentLvlText;
    [SerializeField] private Text _currentProfitText;
    [SerializeField] private Text _currentPriceText;
    [SerializeField] private GameObject _lockPanel;



    private void Start()
    {
        Display();
    }

    public void Display()
    {
        if (PlayerPrefs.GetInt("maraStatue") <= 0)
        {
            _lockPanel.SetActive(true);
        }
        else
        {
            _lockPanel.SetActive(false);
        }
        _currentLvlText.text = (PlayerPrefs.GetInt("maraStatue") + 1).ToString("F0");

        _currentPriceText.text = PlayerPrefs.GetFloat("priceMaraStatue").ToString("F2");
    }
}
