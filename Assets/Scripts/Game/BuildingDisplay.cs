using UnityEngine;
using UnityEngine.UI;

public class BuildingDisplay : MonoBehaviour
{
    [SerializeField] private Text _levelUpgrade;
    [SerializeField] private Text _countGoose;

    private void Start()
    {
        ShowCountGoose();
    }
    private void OnEnable()
    {
        BuyGoose.buyGoose += ShowCountGoose;  
    }
    private void OnDisable()
    {
        BuyGoose.buyGoose -= ShowCountGoose;
    }
    public void ShowCountGoose()
    {
        _countGoose.text = PlayerPrefs.GetInt("goose").ToString("F0");
    }
}
