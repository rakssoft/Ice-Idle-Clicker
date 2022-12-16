using UnityEngine;
using Spine;
using Spine.Unity;


public class MaraStatue : MonoBehaviour
{
    [SerializeField] private SkeletonAnimation _maraAnim;
    [SerializeField] private GameObject _maraVer;

    private void OnEnable()
    {
        Events.AnimMorana += PlayAnim;
    }

    private void OnDisable()
    {
        Events.AnimMorana -= PlayAnim;
    }
    private void Start()
    {
        _maraVer.SetActive(false);
        _maraAnim.GetComponent<MeshRenderer>().sortingOrder = -11;
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
                    _maraVer.SetActive(true);

                    break;
                }
            case 1:
                {
                    _maraAnim.GetComponent<MeshRenderer>().sortingOrder = -1;
                    break;
                }
            case 6:
                {
                    _maraAnim.initialSkinName = "morana_level2";
                    _maraAnim.Initialize(true);
                    PlayAnim("morana_idle3", false);
                    _maraAnim.GetComponent<MeshRenderer>().sortingOrder = -1;
                    break;
                }
            case 10:
                {
                    _maraAnim.initialSkinName = "morana_level3";
                    _maraAnim.Initialize(true);
                    PlayAnim("morana_idle3", false);
                    _maraAnim.GetComponent<MeshRenderer>().sortingOrder = -1;
                    _maraAnim.GetComponent<MeshRenderer>().sortingOrder = -1;
                    break;
                }

        }
    }

    private void PlayAnim(string animName, bool loop)
    {
        _maraAnim.GetComponent<MeshRenderer>().sortingOrder = -1;
        _maraAnim.AnimationState.SetAnimation(0, animName, loop);
        _maraAnim.AnimationState.AddAnimation(0, "morana_idle3" , true, 0);
    }
}
