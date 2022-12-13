using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    [HideInInspector] [SerializeField] private Text _eggText;
    [SerializeField] private Text _eggTextQuest;
    [HideInInspector] [SerializeField] private Text _eggAutoCLickText;
    [SerializeField] private EggText _eggCoinsPrefab;
    [SerializeField] private GameObject[] _spawnEggCoins;
    [SerializeField] private Transform _transformEggCoins;
    [SerializeField] private Shop _shop;
    [SerializeField] private Text _currentCoosekText;
    [SerializeField] private Text _fragmentsWinterText;
    [SerializeField] private Text _fragmentsWinterTextShop;
    [SerializeField] private Text _fragmentsWinterTextUpgrade;
    [SerializeField] private Text _fragmentsWinterTextQuest;
    private float currenteggs;

    private void OnEnable()
    {
        AutoClick.autoclick += RecalEggs;
        InputPlayer.click += RecalEggs;
        Events.ClickHous += RecalEggs;
        Events.ClickHous += SpawnEggCoins;
    }

    private void OnDisable()
    {
        AutoClick.autoclick -= RecalEggs;
        InputPlayer.click -= RecalEggs;
        Events.ClickHous -= RecalEggs;
        Events.ClickHous -= SpawnEggCoins;
    }
    private void Start()
    {
        ShowNumberEggs();
    }

    private void ShowNumberEggs()
    {
        _eggText.text = PlayerPrefs.GetFloat("egg").ToString("F0");
        _eggAutoCLickText.text = PlayerPrefs.GetFloat("autoclick").ToString("F0");
        _currentCoosekText.text = PlayerPrefs.GetInt("goose").ToString();
        float WinterFragments = PlayerPrefs.GetFloat("fragmentswinter");
        _fragmentsWinterText.text = WinterFragments.ToString("F0");
        _fragmentsWinterTextShop.text = WinterFragments.ToString("F0");
        _fragmentsWinterTextUpgrade.text = WinterFragments.ToString("F0");
        _fragmentsWinterTextQuest.text = WinterFragments.ToString("F0");
        _eggTextQuest.text = PlayerPrefs.GetFloat("egg").ToString("F0");
    }

    /// <summary>
    /// пересчитывает €йца и отображает текстом
    /// </summary>
    /// <param name="click"></param>
    public void RecalEggs(float click)
    {
        currenteggs = click;
        PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") + currenteggs);
        _shop.CanBuy();
        ShowNumberEggs();
    }

    private void SpawnEggCoins(float click)
    {
        int random = RandomSpawnEgg();
        EggText eggText = Instantiate(_eggCoinsPrefab, _spawnEggCoins[random].transform.position, Quaternion.identity, _transformEggCoins);
        eggText._eggCurrent = click;        
    }

    private int RandomSpawnEgg()
    {
        int RandomSpawn = Random.Range(0, _spawnEggCoins.Length);
        return RandomSpawn;
    }


}
