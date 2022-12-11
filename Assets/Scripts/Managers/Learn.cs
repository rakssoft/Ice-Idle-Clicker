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
    [SerializeField] private GameObject _learnPanel1;
    [SerializeField] private GameObject _learnPanel2;
    [SerializeField] private GameObject _learnPanel3;
    [SerializeField] private GameObject _learnPanel4;
    [SerializeField] private GameObject _learnPanel5;
    [SerializeField] private GameObject _learnPanel6;
    [SerializeField] private GameObject _learnPanel7;
    [SerializeField] private GameObject _learnPanel8;
    [SerializeField] private GameObject _tutorial;
    [SerializeField] private GameObject _helperQuest;
    [SerializeField] private GameObject _footer;
    [SerializeField] private GameObject _header;
    [SerializeField] private GameObject _gooseMadam;
    [SerializeField] private GameObject _helperGooseMadam;
    [SerializeField] private GameObject _backgroundTotorail;


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
 /*   public void Learn7()
    {
        if(PlayerPrefs.GetInt("learn") == 6)
        {
            PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - 5);
            PlayerPrefs.SetInt("goose", PlayerPrefs.GetInt("goose") + 1);
            _autoClick.RecalAutoClick();
        }       
        _learnPanel6.SetActive(false);
        StartCoroutine(LearnTime7());
        PlayerPrefs.SetInt("learn", 7);
    }*/
    /// <summary>
    /// здесь окно что нужно выполнить скорее ее действия.
    /// </summary>
    /// <returns></returns>
/*    IEnumerator LearnTime7()
    {
        _learnPanel7.SetActive(true);
        yield return new WaitForSeconds(3);              
    }

    public void Learn7_1()
    {
        if (PlayerPrefs.GetInt("learn") < 9)
        {
            if (PlayerPrefs.GetInt("learn") == 7)
            {
                if(PlayerPrefs.GetInt("hous") == 2)
                {
                    _learnPanel7_1.SetActive(false);
                    _learnPanel7.SetActive(false);
                    PlayerPrefs.SetInt("learn", 8);
                    StartCoroutine(LearnTime8());
                }
            
            }
           
        }
    }


    public void Learn8()
    {
        PlayerPrefs.SetFloat("fragmentswinter", 100);
    }

    IEnumerator LearnTime8()
    {
        yield return new WaitForSeconds(3);
        _learnPanel8.SetActive(true);
    }
    public void Learn9()
    {
        _learnPanel8.SetActive(false);
        _tutorial.SetActive(false);
        PlayerPrefs.SetInt("learn", 9);
    }
*/
  

    public void CloseHelperQuest()
    {
        _helperQuest.SetActive(false);
    }
    public void SpeakGoose()
    {
        int IdleRandom = Random.Range(1, 3);
        Events.AnimGoose?.Invoke("speak" + IdleRandom, false);
    }


    private void Update()
    {
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
