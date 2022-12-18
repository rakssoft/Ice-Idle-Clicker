using UnityEngine;
using Spine.Unity;

public class Feeder : MonoBehaviour
{
    [SerializeField] private SkeletonAnimation _feederAnim;
    [SerializeField] private GameObject _feederVer;
    [SerializeField] private GameObject _clickFeeder;
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
        _clickFeeder.SetActive(false);
        _feederVer.SetActive(false);
        int updateFeeder = PlayerPrefs.GetInt("feeder");
        if(updateFeeder > 0)
        {
            _clickFeeder.SetActive(true);
        }
        UpgradeFeeder(updateFeeder);
    }

    public void ClickFeeder()
    {
        int clikFeeder = PlayerPrefs.GetInt("feeder");
        if(clikFeeder < 6)
        {
            PlayAnim("food_click1", false);
        } 
        else if(clikFeeder >= 6 && clikFeeder < 10)
        {
            PlayAnim("food_click2", false);
        }  
        else if(clikFeeder >= 10)
        {
            PlayAnim("food_click3", false);
        }
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
                    _clickFeeder.SetActive(true);
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
