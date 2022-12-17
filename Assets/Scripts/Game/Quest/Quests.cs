using UnityEngine;


public class Quests : MonoBehaviour
{
    [SerializeField] private GameObject _canQuest;



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
        if (PlayerPrefs.GetFloat("egg") >= 500 && PlayerPrefs.GetInt("questMorana") == 0)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetFloat("egg") >= 1000 && PlayerPrefs.GetInt("questMorana") == 1)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetFloat("egg") >= 2000 && PlayerPrefs.GetInt("questMorana") == 2)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetFloat("egg") >= 4000 && PlayerPrefs.GetInt("questMorana") == 3)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetFloat("egg") >= 8000 && PlayerPrefs.GetInt("questMorana") == 4)
        {
            _canQuest.SetActive(true);
        }

        else if (PlayerPrefs.GetInt("hous") >= 10 && PlayerPrefs.GetInt("questHome") == 0)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("hous") >= 20 && PlayerPrefs.GetInt("questHome") == 1)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("hous") >= 30 && PlayerPrefs.GetInt("questHome") == 2)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("hous") >= 40 && PlayerPrefs.GetInt("questHome") == 3)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("hous") >= 50 && PlayerPrefs.GetInt("questHome") == 4)
        {
            _canQuest.SetActive(true);          
        }
        else if (PlayerPrefs.GetInt("goose") >= 10 && PlayerPrefs.GetInt("questGoose") == 0)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("goose") >= 20 && PlayerPrefs.GetInt("questGoose") == 1)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("goose") >= 30 && PlayerPrefs.GetInt("questGoose") == 2)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("goose") >= 40 && PlayerPrefs.GetInt("questGoose") == 3)
        {
            _canQuest.SetActive(true);
        }

        else if (PlayerPrefs.GetInt("fence") >= 1 && PlayerPrefs.GetInt("questFence") == 0)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("fence") >= 2 && PlayerPrefs.GetInt("questFence") == 1)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("fence") >= 3 && PlayerPrefs.GetInt("questFence") == 2)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("feeder") >= 5 && PlayerPrefs.GetInt("questFeeder") == 0)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("feeder") >= 10 && PlayerPrefs.GetInt("questFeeder") == 1)
        {
            _canQuest.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("feeder") >= 15 && PlayerPrefs.GetInt("questFeeder") == 2)
        {
            _canQuest.SetActive(true);
        }
        else
        {
            _canQuest.SetActive(false);
        }
    }
}
