
using UnityEngine;
using UnityEngine.UI;

public class FenceDisplayShop : MonoBehaviour
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
        if (PlayerPrefs.GetInt("fence") <= 0)
        {
            _lockPanel.SetActive(true);
        }
        else
        {
            _lockPanel.SetActive(false);
        }
        _currentLvlText.text = (PlayerPrefs.GetInt("fence") + 1).ToString("F0");
        _currentProfitText.text = PlayerPrefs.GetFloat("profitFence").ToString();
        _currentPriceText.text = PlayerPrefs.GetFloat("priceFence").ToString("F0");
    }
}
