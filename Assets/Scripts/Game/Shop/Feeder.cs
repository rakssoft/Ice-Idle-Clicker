using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feeder : MonoBehaviour
{
    [SerializeField] private GameObject _feederVer1, _feederVer2, _feederVer3;
    private void Start()
    {
        _feederVer1.SetActive(false);
        _feederVer2.SetActive(false);
        _feederVer3.SetActive(false);


        int updateFeeder = PlayerPrefs.GetInt("feeder");
        UpgradeFeeder(updateFeeder);
    }

    public void UpgradeFeeder()
    {
        int updateFeeder = PlayerPrefs.GetInt("feeder");
        UpgradeFeeder(updateFeeder);
    }
    private void UpgradeFeeder(int lvl)
    {
        switch (lvl)
        {
            case 0:
                {
                    _feederVer1.SetActive(false);
                    _feederVer2.SetActive(false);
                    _feederVer3.SetActive(false);
                    break;
                }
            case 1:
                {
                    _feederVer1.SetActive(true);
                    _feederVer2.SetActive(false);
                    _feederVer3.SetActive(false);
                    break;
                }
            case 6:
                {
                    _feederVer1.SetActive(false);
                    _feederVer2.SetActive(true);
                    _feederVer3.SetActive(false);
                    break;
                }
            case 10:
                {
                    _feederVer1.SetActive(false);
                    _feederVer2.SetActive(false);
                    _feederVer3.SetActive(true);
                    break;
                }

        }
    }
}
