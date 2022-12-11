using UnityEngine;
using Spine;
using Spine.Unity;

public class Hous : MonoBehaviour
{
   [SerializeField] private GameObject _housVer;
    [SerializeField] private SkeletonAnimation _homeAnim;
    private int idHome;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Events.AnimHouseClick += ClickHome;
    }

    private void OnDisable()
    {
        Events.AnimHouseClick -= ClickHome;
    }

    private void PlayAnim(string animName, bool loop)
    {
        idHome = IDHome();
        _homeAnim.AnimationState.SetAnimation(0, animName, loop);
        _homeAnim.AnimationState.AddAnimation(0, "house_idle_" + idHome, true, 0);
    }
    private void Start()
    {
       int updateHouse = PlayerPrefs.GetInt("hous");
        UpgradeHous(updateHouse);
    }

    public void UpgradeHous()
    {
        int updateHouse = PlayerPrefs.GetInt("hous");
        UpgradeHous(updateHouse);
    }
    /// <summary>
    /// устанавливает значение айди дома для анмации  айдла дома
    /// </summary>
    /// <returns></returns>
    private int IDHome()
    {
        if(PlayerPrefs.GetInt("hous") < 2)
        {
            idHome = 1;
        }
        else if((PlayerPrefs.GetInt("hous") >= 2) && (PlayerPrefs.GetInt("hous") < 6))
        {
            idHome = 2;
        } 
        else if((PlayerPrefs.GetInt("hous") >= 6) && (PlayerPrefs.GetInt("hous") < 10))
        {
            idHome = 3;
        } 
        else if((PlayerPrefs.GetInt("hous") >= 10))
        {
            idHome = 4;
        }
        return idHome;
    }

    /// <summary>
    /// клик на доме с анимацией
    /// </summary>
    private void ClickHome()
    {
        idHome = IDHome();
        PlayAnim("house_clik_" + idHome, false);
    }
        
    /// <summary>
    /// апгрейд дома гусыни после покупки в зависимости от айди дома
    /// </summary>
    /// <param name="lvl"></param>
    private void UpgradeHous(int lvl)
    {
        switch (lvl)
        {
            case 0:
                {
                    _housVer.SetActive(false);

                    break;
                }
            case 1:
                {
                    _housVer.SetActive(true);

                    PlayAnim("house_appearance_1", false);
                    break;
                }
            case 2:
                {
                    _housVer.SetActive(true);
                    PlayAnim("house_upgrade_1", false);
                    break;
                } 
            case 6:
                {
                    _housVer.SetActive(true);
                    PlayAnim("house_upgrade_2", false);
                    break;
                } 
            case 10:
                {
                    _housVer.SetActive(true);
                    PlayAnim("house_upgrade_3", false);
                    break;
                } 
     
        }
    }

   
}
