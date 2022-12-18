using UnityEngine;
using Spine;
using Spine.Unity;


public class MaraStatue : MonoBehaviour
{
    [SerializeField] private SkeletonAnimation _maraAnim;
    [SerializeField] private GameObject _maraVer;
    [SerializeField] private GameObject _clickMorana;
    private string idle;
    private void OnEnable()
    {
        Events.AnimMorana += PlayAnim;
        Events.SotredMorana += Sorted;
    }

    private void OnDisable()
    {
        Events.AnimMorana -= PlayAnim;
        Events.SotredMorana += Sorted;
    }
    private void Start()
    {
        _maraVer.SetActive(false);
        idle = "morana_idle";
        _maraAnim.GetComponent<MeshRenderer>().sortingOrder = -11;
        int updateMara = PlayerPrefs.GetInt("maraStatue");
        UpgradeMara(updateMara);
    }

    public void ClickMorana()
    {
        PlayAnim("morana_click", false);
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
                    _clickMorana.SetActive(true);
                    idle = "morana_idle";
                    break;
                }
            case 1:
                {
                    _clickMorana.SetActive(true);
                    idle = "morana_idle2";
                    Skin("morana_level_2");
                    break;
                }
            case 2:
                {
                    _clickMorana.SetActive(true);
                    idle = "morana_idle3";
                    Skin("morana_level_3");
                    break;
                }
        }
    }

    private void PlayAnim(string animName, bool loop)
    {
        _maraAnim.AnimationState.SetAnimation(0, animName, loop);
        _maraAnim.AnimationState.AddAnimation(0, idle , true, 0);
    }

    private void Skin(string skin)
    {
        _maraAnim.initialSkinName = skin;
        _maraAnim.Initialize(true);
        if(skin == "morana_level_2")
        {
         PlayAnim("morana_upgrade1", false);
        }
        else if (skin == "morana_level_3")
        {
            PlayAnim("morana_upgrade2", false);
        }


    }

    private void Sorted()
    {
        _maraAnim.GetComponent<MeshRenderer>().sortingOrder = -1;
    }
}
