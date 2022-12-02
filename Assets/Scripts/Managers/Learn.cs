using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Learn : MonoBehaviour
{
    [SerializeField] private AutoClick _autoClick;
    [SerializeField] private Shop _shop;
    [SerializeField] private GameObject _learnPanel1;
    [SerializeField] private GameObject _learnPanel2;
    [SerializeField] private GameObject _learnPanel2_1;
    [SerializeField] private GameObject _learnPanel3;
    [SerializeField] private GameObject _learnPanel4;
    [SerializeField] private GameObject _learnPanel5;
    [SerializeField] private GameObject _learnPanel5_1;
    [SerializeField] private GameObject _learnPanel6;
    [SerializeField] private GameObject _learnPanel7;
    [SerializeField] private GameObject _learnPanel8;
    private Hous _hous;

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
                    Learn9();
                    break;
                }  
            case 9:
                {

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
        _learnPanel1.SetActive(true);
        PlayerPrefs.SetInt("learn", 1);
    }

    /// <summary>
    ///  Нажимай на гусыню
    /// </summary>
    private void Learn2()
    {
        _learnPanel1.SetActive(false);
        _learnPanel2.SetActive(true);
        PlayerPrefs.SetInt("learn", 2);
    }
    /// <summary>
    /// нажми купить авто сбор
    /// </summary>
    private void Learn3()
    {
        _learnPanel2.SetActive(false);
        _learnPanel3.SetActive(true);
        PlayerPrefs.SetInt("learn", 3);
    }
    /// <summary>
    /// экран покупки автосбора - дома
    /// </summary>
    private void Learn4()
    {
        _learnPanel3.SetActive(false);
        _learnPanel4.SetActive(true);
        PlayerPrefs.SetInt("learn", 4);
    }
    /// <summary>
    /// покупка домика автоклика
    /// </summary>

    public void Learn5()
    {
        if (PlayerPrefs.GetInt("learn") == 4)
        {
            _shop.BuyUpgradeHous();
      /*      PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - 50);
            PlayerPrefs.SetInt("hous", 1);
            _autoClick.RecalAutoClick();*/
        }
        _learnPanel4.SetActive(false);
        _hous.UpgradeHous();
        PlayerPrefs.SetInt("learn", 5);
        _learnPanel5_1.SetActive(true);
        StartCoroutine(LearnTime5());       
    }

    /// <summary>
    /// открывается что пора купить еще гусыню
    /// </summary>
    /// <returns></returns>
    IEnumerator LearnTime5()
    {
        yield return new WaitForSeconds(15);
        _learnPanel5_1.SetActive(false);
        _learnPanel5.SetActive(true);
    }

    /// <summary>
    /// открывается окно для покупки гусыни.
    /// </summary>
    public void Learn6()
    {
        _learnPanel5_1.SetActive(false);
        _learnPanel5.SetActive(false);
        _learnPanel6.SetActive(true);
        PlayerPrefs.SetInt("learn", 6);
    }

    /// <summary>
    /// нажимается кнопка покупки гусыни
    /// </summary>
    public void Learn7()
    {
        if(PlayerPrefs.GetInt("learn") == 6)
        {
            PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - 15);
            PlayerPrefs.SetInt("goose", PlayerPrefs.GetInt("goose") + 1);
            _autoClick.RecalAutoClick();
        }       
        _learnPanel6.SetActive(false);
        StartCoroutine(LearnTime7());
        PlayerPrefs.SetInt("learn", 7);
    }
    /// <summary>
    /// здесь окно что нужно выполнить скорее ее действия.
    /// </summary>
    /// <returns></returns>
    IEnumerator LearnTime7()
    {
        _learnPanel7.SetActive(true);
        yield return new WaitForSeconds(5);
        _learnPanel7.SetActive(false);
        yield return new WaitForSeconds(15);
        Learn8();
       
    }

    public void Learn8()
    {
        StartCoroutine(LearnTime8());

  
    }

    IEnumerator LearnTime8()
    {
        yield return new WaitForSeconds(15);
        _learnPanel8.SetActive(true);
        PlayerPrefs.SetInt("learn", 8);
        yield return new WaitForSeconds(6);
        Learn9();
    }
    public void Learn9()
    {
        _learnPanel8.SetActive(false);
    //    StartCoroutine(LearnTime9());
        PlayerPrefs.SetInt("learn", 9);
/*        IEnumerator LearnTime9()
        {
            yield return new WaitForSeconds(15);
            _learnPanel8.SetActive(true);
        }*/
    }

    


    private void Update()
    {


        if (PlayerPrefs.GetFloat("egg") == 5 && PlayerPrefs.GetInt("learn") == 2)
        {
            _learnPanel2_1.SetActive(false);
        }
        else if (PlayerPrefs.GetFloat("egg") == 50 && PlayerPrefs.GetInt("learn") == 2)
        {
            Learn3();
        }
    }
}
