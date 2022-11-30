using UnityEngine;

public class Hous : MonoBehaviour
{
    [SerializeField] private GameObject _housVer1, _housVer2, _housVer3;
    [SerializeField] private GameObject _goose;
    private void Start()
    {
        _housVer1.SetActive(false);
        _housVer2.SetActive(false);
        _housVer3.SetActive(false);
        _goose.SetActive(true);

       int updateHouse = PlayerPrefs.GetInt("hous");
        UpgradeHous(updateHouse);
    }

    public void UpgradeHous()
    {
        int updateHouse = PlayerPrefs.GetInt("hous");
        UpgradeHous(updateHouse);
    }
    private void UpgradeHous(int lvl)
    {
        switch (lvl)
        {
            case 0:
                {
                    _housVer1.SetActive(false);
                    _housVer2.SetActive(false);
                    _housVer3.SetActive(false);
                    _goose.SetActive(true);
                    break;
                }
            case 1:
                {
                    _housVer1.SetActive(true);
                    _housVer2.SetActive(false);
                    _housVer3.SetActive(false);
                    _goose.SetActive(false);
                    break;
                }
            case 2:
                {
                    _housVer1.SetActive(false);
                    _housVer2.SetActive(true);
                    _housVer3.SetActive(false);
                    _goose.SetActive(false);
                    break;
                } 
            default:
                {
                    _housVer1.SetActive(false);
                    _housVer2.SetActive(false);
                    _housVer3.SetActive(true);
                    _goose.SetActive(false);
                    break;
                }       
        }
    }

   
}
