using UnityEngine;

public class Fence : MonoBehaviour
{
    [SerializeField] private GameObject _fenceVer1, _fenceVer2, _fencerVer3;
    private void Start()
    {
        _fenceVer1.SetActive(false);
        _fenceVer2.SetActive(false);
        _fencerVer3.SetActive(false);


        int updateFence = PlayerPrefs.GetInt("fence");
        UpgradeFence(updateFence);
    }

    public void UpgradeFence()
    {
        int updateFence = PlayerPrefs.GetInt("fence");
        UpgradeFence(updateFence);
    }
    private void UpgradeFence(int lvl)
    {
        switch (lvl)
        {
            case 0:
                {
                    _fenceVer1.SetActive(false);
                    _fenceVer2.SetActive(false);
                    _fencerVer3.SetActive(false);
                    break;
                }
            case 1:
                {
                    _fenceVer1.SetActive(true);
                    _fenceVer2.SetActive(false);
                    _fencerVer3.SetActive(false);
                    break;
                }
            case 6:
                {
                    _fenceVer1.SetActive(false);
                    _fenceVer2.SetActive(true);
                    _fencerVer3.SetActive(false);
                    break;
                }
            case 10:
                {
                    _fenceVer1.SetActive(false);
                    _fenceVer2.SetActive(false);
                    _fencerVer3.SetActive(true);
                    break;
                }

        }
    }
}
