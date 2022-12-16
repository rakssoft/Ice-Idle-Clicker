using UnityEngine;
using Spine.Unity;
public class Fence : MonoBehaviour
{
    [SerializeField] private GameObject _fenceVer;
    [SerializeField] private SkeletonAnimation _fenceAnim;
    private string _idleAnim;

    private void OnEnable()
    {
        Events.AnimFence += PlayAnim;
    }

    private void OnDisable()
    {
        Events.AnimFence -= PlayAnim;
    }
    private void Start()
    {
        _fenceVer.SetActive(false);
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
                    _fenceVer.SetActive(false);

                    break;
                }
            case 1:
                {
                    _fenceVer.SetActive(true);
                    _idleAnim = "fence_idle1";
                    break;
                }
            case 6:
                {
                    _idleAnim = "fence_idle1";
                    _fenceVer.SetActive(true);
                    break;
                }
            case 10:
                {
                    _idleAnim = "fence_idle3";
                    _fenceVer.SetActive(true);
                    break;
                }

        }
    }
    private void PlayAnim(string animName, bool loop)
    {
        UpgradeFence();
        _fenceAnim.AnimationState.SetAnimation(0, animName, loop);
        _fenceAnim.AnimationState.AddAnimation(0, _idleAnim, true, 0);
    }
}
