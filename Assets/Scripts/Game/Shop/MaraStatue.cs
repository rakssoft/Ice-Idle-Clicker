
using UnityEngine;

public class MaraStatue : MonoBehaviour
{
    [SerializeField] private GameObject _maraVer1, _maraVer2, _maraVer3;
    private void Start()
    {
        _maraVer1.SetActive(false);
        _maraVer2.SetActive(false);
        _maraVer3.SetActive(false);


        int updateMara = PlayerPrefs.GetInt("maraStatue");
        UpgradeMara(updateMara);
    }

    public void UpgradeMara()
    {
        int updateMara = PlayerPrefs.GetInt("maraStatue");
        UpgradeMara(updateMara);
    }
    private void UpgradeMara(int lvl)
    {
        switch (lvl)
        {
            case 0:
                {
                    _maraVer1.SetActive(false);
                    _maraVer2.SetActive(false);
                    _maraVer3.SetActive(false);
                    break;
                }
            case 1:
                {
                    _maraVer1.SetActive(true);
                    _maraVer2.SetActive(false);
                    _maraVer3.SetActive(false);
                    break;
                }
            case 6:
                {
                    _maraVer1.SetActive(false);
                    _maraVer2.SetActive(true);
                    _maraVer3.SetActive(false);
                    break;
                }
            case 10:
                {
                    _maraVer1.SetActive(false);
                    _maraVer2.SetActive(false);
                    _maraVer3.SetActive(true);
                    break;
                }

        }
    }
}
