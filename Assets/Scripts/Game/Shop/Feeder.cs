using UnityEngine;
using Spine.Unity;

public class Feeder : MonoBehaviour
{
    [SerializeField] private SkeletonAnimation _feederAnim;
    [SerializeField] private GameObject _feederVer;
    private string _idleAnim;
    private void OnEnable()
    {
        Events.AnimFeeder += PlayAnim;
    }

    private void OnDisable()
    {
        Events.AnimFeeder -= PlayAnim;
    }
    private void Start()
    {
        _idleAnim = "food_idle1";
        _feederVer.SetActive(false);
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
                    _feederVer.SetActive(false);
                    _feederAnim.GetComponent<MeshRenderer>().sortingOrder = -11;
                    break;
                }
            case 1:
                {
                    _feederVer.SetActive(true);
                    _feederAnim.GetComponent<MeshRenderer>().sortingOrder = 0;
                    _idleAnim = "food_idle1";
                    break;
                }
            case 6:
                {
                    _feederAnim.GetComponent<MeshRenderer>().sortingOrder = 0;
                    _feederVer.SetActive(true);
                    _idleAnim = "food_idle2";
                    break;
                }
            case 10:
                {
                    _feederAnim.GetComponent<MeshRenderer>().sortingOrder = 0;
                    _feederVer.SetActive(true);
                    _idleAnim = "food_idle3";
                    break;
                }

        }
    }

    private void PlayAnim(string animName, bool loop)
    {
        _feederAnim.GetComponent<MeshRenderer>().sortingOrder = 0;       
        _feederAnim.AnimationState.SetAnimation(0, animName, loop);
        UpgradeFeeder();
        _feederAnim.AnimationState.AddAnimation(0, _idleAnim, true, 0);
    }
}
