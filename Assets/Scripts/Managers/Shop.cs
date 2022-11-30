using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    
 [HideInInspector]   [SerializeField] private GameObject _housShop1, _housShop2, _housShop3;
    [SerializeField] private Button _maxLevelHous;
    [SerializeField] private float _multiplyPriceBuidings;
    [SerializeField] private float _multiplyIncomeBuidings;
    private Hous _hous;


    private void Awake()
    {
        _hous = GetComponent<Hous>();
    }
    private void Start()
    {
        _housShop1.SetActive(false);
        _housShop2.SetActive(false);
        _housShop3.SetActive(false);
 
        int updateHouse = PlayerPrefs.GetInt("hous");
        UpgradeHous(updateHouse);
        _hous.UpgradeHous();
    }
    public void UpgradeHous()
    {
        int updateHouse = PlayerPrefs.GetInt("hous");
        UpgradeHous(updateHouse);
        _hous.UpgradeHous();

    }
    /// <summary>
    /// ����� �������������� ����������� ��� �� ������ �������� � ����� ����� ������ ������� �������.
    /// </summary>
    /// <param name="lvl"></param>
    private void UpgradeHous(int lvl)
    {
        switch (lvl)
        {
            case 1:
                {
                    _housShop1.SetActive(false);
                    _housShop2.SetActive(true);
                    _housShop3.SetActive(false);
                
                    break;
                }
            case 2:
                {
                    _housShop1.SetActive(false);
                    _housShop2.SetActive(false);
                    _housShop3.SetActive(true);
                    break;
                }
            default:
                {
                    _housShop3.SetActive(true);
                    _maxLevelHous.interactable = false;
                    break;
                }
        }
    }
    /// <summary>
    /// ��������� ���� ������������� � DataSave � ����� ����� ���� ��������� � ���������
    /// ���� �� ������� ���� � ���������� ��� �������� (�� �����������)
    /// </summary>
    public void BuyUpgradeHous()
    {
        if (PlayerPrefs.GetFloat("egg") >= PlayerPrefs.GetFloat("priceHous"))
        {
            PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - PlayerPrefs.GetFloat("priceHous"));
            PlayerPrefs.SetInt("hous", PlayerPrefs.GetInt("hous") + 1);
            PlayerPrefs.SetFloat("autoclick", PlayerPrefs.GetFloat("autoclick") * _multiplyIncomeBuidings);
            PlayerPrefs.SetFloat("priceHous", PlayerPrefs.GetFloat("priceHous") * _multiplyPriceBuidings);
            UpgradeHous();
        }
    }
}
