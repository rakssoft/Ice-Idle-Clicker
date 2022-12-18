using UnityEngine;
using UnityEngine.UI;


public class Quests : MonoBehaviour
{
    [SerializeField] private GameObject _canQuest;
    [SerializeField] private Button _buttonMorana;
    [SerializeField] private Button _buttonHous;
    [SerializeField] private Button _buttonFence;
    [SerializeField] private Button _buttonGoose;
    [SerializeField] private Button _buttonFeeder;
    private bool morana;
    private bool hous;
    private bool fence;
    private bool goose;
    private bool feeder;



    private void OnEnable()
    {
        Events.CanQuest += CanQuests;
    }

    private void OnDisable()
    {
        Events.CanQuest -= CanQuests;
    }


    private void CanQuests()
    {

        if(CanMorana() == true)
        {
            _buttonMorana.interactable = true;
            _canQuest.SetActive(true);
        }
        else
        {
            _buttonMorana.interactable = false;
        }

        if(CanHous() == true)
        {
            _buttonHous.interactable = true;
            _canQuest.SetActive(true);
        }
        else
        {
            _buttonHous.interactable = false;
        }

        if(CanGoose() == true)
        {
            _buttonGoose.interactable = true;
            _canQuest.SetActive(true);
        }
        else
        {
            _buttonGoose.interactable = false;
        } 
        if(CanFence() == true)
        {
            _buttonFence.interactable = true;
            _canQuest.SetActive(true);
        }
        else
        {
            _buttonFence.interactable = false;
        }
        if(CanFeeder() == true)
        {
            _buttonFeeder.interactable = true;
            _canQuest.SetActive(true);
        }
        else
        {
            _buttonFeeder.interactable = false;
        }
        if(CanMorana() == false && CanHous() == false && CanGoose() == false && CanFence() == false && CanFeeder() == false)
        {
            _canQuest.SetActive(false);
        }

        
    }

    private bool CanMorana()
    {
        if (PlayerPrefs.GetFloat("egg") >= 500 && PlayerPrefs.GetInt("questMorana") == 0)
        {
            morana = true;
        }
        else if (PlayerPrefs.GetFloat("egg") >= 1000 && PlayerPrefs.GetInt("questMorana") == 1)
        {
            morana = true;
        }
        else if (PlayerPrefs.GetFloat("egg") >= 2000 && PlayerPrefs.GetInt("questMorana") == 2)
        {
            morana = true;
        }
        else if (PlayerPrefs.GetFloat("egg") >= 4000 && PlayerPrefs.GetInt("questMorana") == 3)
        {
            morana = true;
        }
        else if (PlayerPrefs.GetFloat("egg") >= 8000 && PlayerPrefs.GetInt("questMorana") == 4)
        {
            morana = true;
        }
        else
        {
            morana = false;
        }
        return morana;
    }

    private bool CanHous()
    {

        if (PlayerPrefs.GetInt("hous") >= 10 && PlayerPrefs.GetInt("questHome") == 0)
        {
            hous = true;
        }
        else if (PlayerPrefs.GetInt("hous") >= 20 && PlayerPrefs.GetInt("questHome") == 1)
        {
            hous = true;
        }
        else if (PlayerPrefs.GetInt("hous") >= 30 && PlayerPrefs.GetInt("questHome") == 2)
        {
            hous = true;
        }
        else if (PlayerPrefs.GetInt("hous") >= 40 && PlayerPrefs.GetInt("questHome") == 3)
        {
            hous = true;
        }
        else if (PlayerPrefs.GetInt("hous") >= 50 && PlayerPrefs.GetInt("questHome") == 4)
        {
            hous = true;
        }
        else
        {
            hous = false;
        }
        return hous;
    }

    private bool CanGoose()
    {

        if (PlayerPrefs.GetInt("goose") >= 10 && PlayerPrefs.GetInt("questGoose") == 0)
        {
            goose = true;
        }
        else if (PlayerPrefs.GetInt("goose") >= 20 && PlayerPrefs.GetInt("questGoose") == 1)
        {
            goose = true;
        }
        else if (PlayerPrefs.GetInt("goose") >= 30 && PlayerPrefs.GetInt("questGoose") == 2)
        {
            goose = true;
        }
        else if (PlayerPrefs.GetInt("goose") >= 40 && PlayerPrefs.GetInt("questGoose") == 3)
        {
            goose = true;
        }
        else
        {
            goose = false;
        }
        return goose;
    }

    private bool CanFence()
    {
        if (PlayerPrefs.GetInt("fence") >= 1 && PlayerPrefs.GetInt("questFence") == 0)
        {
            fence = true;
        }
        else if (PlayerPrefs.GetInt("fence") >= 5 && PlayerPrefs.GetInt("questFence") == 1)
        {
            fence = true;
        }
        else if (PlayerPrefs.GetInt("fence") >= 8 && PlayerPrefs.GetInt("questFence") == 2)
        {
            fence = true;
        }
        else
        {
            fence = false;
        }
        return fence;
    }

    private bool CanFeeder()
    {

        if (PlayerPrefs.GetInt("feeder") >= 5 && PlayerPrefs.GetInt("questFeeder") == 0)
        {
            feeder = true;
        }
        else if (PlayerPrefs.GetInt("feeder") >= 10 && PlayerPrefs.GetInt("questFeeder") == 1)
        {
            feeder = true;
        }
        else if (PlayerPrefs.GetInt("feeder") >= 15 && PlayerPrefs.GetInt("questFeeder") == 2)
        {
            feeder = true;
        }
        else
        {
            feeder = false;
        }
        return feeder;
    }
 
}
