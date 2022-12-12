using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Learn : MonoBehaviour
{

    [SerializeField] private Text _curentEggTextLearn;
    [SerializeField] private Hous _hous;
    [SerializeField] private Quests _quests;
    [SerializeField] private AutoClick _autoClick;
    [SerializeField] private Shop _shop;
    [SerializeField] private GameObject _shopPanel;
    [SerializeField] private GameObject _upgradePanel;
    [SerializeField] private GameObject _learnPanel1;
    [SerializeField] private GameObject _learnPanel2;
    [SerializeField] private GameObject _learnPanel3;
    [SerializeField] private GameObject _learnPanel4;
    [SerializeField] private GameObject _learnPanel5;
    [SerializeField] private GameObject _learnPanel6;
    [SerializeField] private GameObject _learnPanel7;
    [SerializeField] private GameObject _learnPanel8;
    [SerializeField] private GameObject _learnPanel9;
    [SerializeField] private GameObject _learnPanel10;
    [SerializeField] private GameObject _learnPanel11;
    [SerializeField] private GameObject _learnPanel12;
    [SerializeField] private GameObject _learnPanel13;
    [SerializeField] private GameObject _learnPanel14;
    [SerializeField] private GameObject _learnPanel15;
    [SerializeField] private GameObject _tutorial;
    [SerializeField] private GameObject _helperQuest;
    [SerializeField] private GameObject _footer;
    [SerializeField] private GameObject _header;
    [SerializeField] private GameObject _gooseMadam;
    [SerializeField] private GameObject _helperGooseMadam;
    [SerializeField] private GameObject _backgroundTotorail;
    [SerializeField] private GameObject _backgroundTotorailMorana;
    [SerializeField] private GameObject _buyHomeLearn5;
    [SerializeField] private GameObject _buyLearn8;
    [SerializeField] private GameObject _clickPanelHous;


    private void Awake()
    {
        _hous = GetComponent<Hous>();
    }


    private void Start()
    {
        int learn = PlayerPrefs.GetInt("learn");
        
        switch (learn)
        {
            case 0:
                {
                    Learn1();
                    break;
                }
            case 1:
                {
                    Learn2();
                    break;
                } 
            case 2:
                {
                    Learn3();
                    break;
                }
            case 3:
                {
                    Learn4();
                    break;
                } 
            case 4:
                {
                    Learn5();
                    break;
                } 
            case 5:
                {
                    Learn6();
                    break;
                } 
            case 6:
                {
                    Learn7();
                    break;
                } 
            case 7:
                {
                    Learn8();
                    break;
                }  
            case 8:
                {
                 //   Learn9();
                    break;
                }  
            case 9:
                {
                //    Learn9();
                    break;
                }
            default:
                break;
        }
    }

    /// <summary>
    /// Learne 0
    /// </summary>
    private void Learn1()
    {
        SpeakGoose();
        _learnPanel1.SetActive(true);
        _footer.SetActive(false);
        _header.SetActive(false);
        PlayerPrefs.SetInt("learn", 1);
  
    }

    /// <summary>
    ///  Нажимай на гусыню
    /// </summary>
    public void Learn2()
    {     
        _learnPanel1.SetActive(false);
        _learnPanel2.SetActive(true);
        _gooseMadam.SetActive(true);
        PlayerPrefs.SetInt("learn", 2);      
    }

    public void Learn3()
    {
        PlayerPrefs.SetInt("learn", 3);
        _learnPanel2.SetActive(false);
        _learnPanel3.SetActive(true);
        _gooseMadam.SetActive(true);
        _footer.SetActive(true);
        _header.SetActive(true);
        _helperGooseMadam.SetActive(true);
    }

    /// <summary>
    /// нажми купить авто сбор
    /// </summary>
    private void Learn4()
    {
        PlayerPrefs.SetInt("learn", 4);
        _learnPanel3.SetActive(false);
        _learnPanel4.SetActive(true);
        _gooseMadam.SetActive(true);
        _footer.SetActive(false);
        _header.SetActive(false);
        SpeakGoose();

    }

    public void Learn5()
    {
        PlayerPrefs.SetInt("learn", 5);
        _learnPanel4.SetActive(false);
        _learnPanel5.SetActive(true);
        _footer.SetActive(true);
        _header.SetActive(true);
        _gooseMadam.SetActive(true);
        _buyHomeLearn5.SetActive(true);
    }

   public void Learn6()
    {
        _learnPanel6.SetActive(true);
        PlayerPrefs.SetInt("learn", 6);
        _learnPanel5.SetActive(false);       
        _gooseMadam.SetActive(false);
        StartCoroutine(Learn6_1());
    }

    IEnumerator Learn6_1()
    {
        yield return new WaitForSeconds(10);
        Learn7();
    }

    public void Learn7()
    {
        PlayerPrefs.SetInt("learn", 7);
        _learnPanel6.SetActive(false);
        _learnPanel7.SetActive(true);      
        _backgroundTotorail.SetActive(true);
        _footer.SetActive(false);
        _header.SetActive(false);
        _gooseMadam.SetActive(false);
        _buyHomeLearn5.SetActive(false);
    }  
    public void Learn8()
    {
        PlayerPrefs.SetInt("learn", 8);
        _learnPanel7.SetActive(false);
        _learnPanel8.SetActive(true);      
        _backgroundTotorail.SetActive(false);
        _footer.SetActive(true);
        _header.SetActive(true);
        _gooseMadam.SetActive(false);       
    }

    /// <summary>
    /// нажимается кнопка покупки гусыни
    /// </summary>
    public void Learn9()
    {
       
        if(PlayerPrefs.GetInt("goose") >= 2)
        {
            PlayerPrefs.SetInt("learn", 9);
            StartCoroutine(LearnTime10());
        }
       

    }

    IEnumerator LearnTime10()
    {
        yield return new WaitForSeconds(3);
        Learn10();
        
    }
    public void Learn10()
    {
        PlayerPrefs.SetInt("learn", 10);
        _upgradePanel.SetActive(false);
        _learnPanel8.SetActive(false);
        _learnPanel9.SetActive(true);
        _backgroundTotorail.SetActive(true);
        _footer.SetActive(false);
        _header.SetActive(false);

    } 
    public void Learn11()
    {
        PlayerPrefs.SetInt("learn", 11);
        _learnPanel9.SetActive(false);
        _learnPanel10.SetActive(true);
        _backgroundTotorail.SetActive(false);
        _footer.SetActive(true);
        _header.SetActive(true);
        _buyHomeLearn5.SetActive(false);

    }

    public void Learn12()
    {
            PlayerPrefs.SetInt("learn", 12);
            _shopPanel.SetActive(false);
            StartCoroutine(LearnTime13());
        
    }
    IEnumerator LearnTime13()
    {
        yield return new WaitForSeconds(3);
        Learn13();

    }

    public void Learn13()
    {
        PlayerPrefs.SetInt("learn", 13);
        _learnPanel10.SetActive(false);
        _learnPanel11.SetActive(true);
        _backgroundTotorail.SetActive(true);
        _footer.SetActive(false);
        _header.SetActive(false);

    }

    public void Learn14()
    {
        PlayerPrefs.SetInt("learn", 14);
        _learnPanel11.SetActive(false);
        _learnPanel12.SetActive(true);
        _backgroundTotorail.SetActive(false);
        _footer.SetActive(true);
        _header.SetActive(true);
        StartCoroutine(LearnTime15());

    }
    IEnumerator LearnTime15()
    {
        yield return new WaitForSeconds(3);
        Learn15();

    }

    public void Learn15()
    {
        PlayerPrefs.SetInt("learn", 15);
        _learnPanel12.SetActive(false);
        _learnPanel13.SetActive(true);
        _backgroundTotorailMorana.SetActive(true);
        _footer.SetActive(false);
        _header.SetActive(false);

    } 
    
    public void Learn16()
    {
        PlayerPrefs.SetInt("learn", 16);
        _learnPanel13.SetActive(false);
        _learnPanel14.SetActive(true);
        _backgroundTotorailMorana.SetActive(false);
        _footer.SetActive(true);
        _header.SetActive(true);
    } 
    public void Learn17()
    {
        PlayerPrefs.SetInt("learn", 17);
        _learnPanel14.SetActive(false);
        _learnPanel15.SetActive(true);
        _backgroundTotorail.SetActive(true);
        _footer.SetActive(false);
        _header.SetActive(false);
    }

    public void OffLearn()
    {
        PlayerPrefs.SetInt("learn", 17);
        _learnPanel15.SetActive(false);
        _backgroundTotorail.SetActive(false);
        _footer.SetActive(true);
        _header.SetActive(true);
    }




    public void CloseHelperQuest()
    {
        _helperQuest.SetActive(false);
    }
    public void SpeakGoose()
    {
        int IdleRandom = Random.Range(1, 3);
        Events.AnimGoose?.Invoke("speak" + IdleRandom, false);
    }

    public void WinterEgg()
    {
        PlayerPrefs.SetFloat("fragmentswinter", 100);
    }

    private void Update()
    {
        if(PlayerPrefs.GetInt("learn") == 17)
        {
            _clickPanelHous.SetActive(true);
        }
        if (PlayerPrefs.GetInt("hous") == 2 && PlayerPrefs.GetInt("learn") == 11)
        {
            Learn12();
        }
        if (PlayerPrefs.GetFloat("egg") >= 5 && PlayerPrefs.GetFloat("egg") <= 49 && PlayerPrefs.GetInt("learn") == 3)
        {
            _helperGooseMadam.SetActive(false);
        }
        else if (PlayerPrefs.GetFloat("egg") >= 50 && PlayerPrefs.GetInt("learn") == 3)
        {
            Learn4();
        }

        if(PlayerPrefs.GetInt("quest") == 0 && PlayerPrefs.GetFloat("egg") >= 500)
        {
            _helperQuest.SetActive(true);
        }
        else
        {
            _helperQuest.SetActive(false);
        }

        if (_curentEggTextLearn)
        {
            _curentEggTextLearn.text = PlayerPrefs.GetFloat("egg").ToString();
        }
    }



}
