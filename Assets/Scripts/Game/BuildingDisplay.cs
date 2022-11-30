using UnityEngine;
using UnityEngine.UI;

public class BuildingDisplay : MonoBehaviour
{
    [SerializeField] private Text _levelUpgrade;
    [SerializeField] private Text _countGoose;

    private void Start()
    {
        ShowCountGoose(PlayerPrefs.GetInt("goose"));
    }
    private void OnEnable()
    {
        BuyGoose.coutnGoose += ShowCountGoose;  
    }
    private void OnDisable()
    {
        BuyGoose.coutnGoose -= ShowCountGoose;
    }
    public void ShowCountGoose(int goose)
    {
        _countGoose.text = PlayerPrefs.GetInt("goose").ToString("F0");
    }
}
