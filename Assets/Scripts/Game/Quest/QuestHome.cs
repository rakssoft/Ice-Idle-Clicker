using UnityEngine;
using UnityEngine.UI;

public class QuestHome : MonoBehaviour
{
    [SerializeField] private Button _complitButton;
    [SerializeField] private Text _textButton;
    [SerializeField] private Text _descriptionQuestText;
    [SerializeField] private Text _profitQuestText;
    private string[] DecsQuest = new[] { "Купить домик для гусынь 10 уровня",
                                         "Купить домик для гусынь 20 уровня",
                                         "Купить домик для гусынь 30 уровня",
                                         "Купить домик для гусынь 40 уровня",
                                         "Купить домик для гусынь 50 уровня" };
    private int[] ProfitQuest = new int[] {10,15,20,25,30};
    private int _currentLvlQuest;

    public void ShowQuest()
    {
        if (PlayerPrefs.GetInt("questHome") == 5)
        {
            _complitButton.interactable = false;
            _textButton.text = "выполнено".ToString();
        }
        else
        {
            _currentLvlQuest = PlayerPrefs.GetInt("questHome");
            _descriptionQuestText.text = DecsQuest[_currentLvlQuest].ToString();
            _profitQuestText.text = ProfitQuest[_currentLvlQuest].ToString();
        }
    

    }

    public void CompleteQuest()
    {

        if (PlayerPrefs.GetInt("hous") >= 10  && PlayerPrefs.GetInt("questHome") == 0)
        {
            SaveProfit();
            PlayerPrefs.SetInt("questHome", 1);            
        }
        else if (PlayerPrefs.GetInt("hous") >= 20  && PlayerPrefs.GetInt("questHome") == 1)
        {
            SaveProfit();
            PlayerPrefs.SetInt("questHome", 2);           
        }
        else if (PlayerPrefs.GetInt("hous") >= 30  && PlayerPrefs.GetInt("questHome") == 2)
        {
            SaveProfit();
            PlayerPrefs.SetInt("questHome", 3);           
        }
        else if (PlayerPrefs.GetInt("hous") >= 40  && PlayerPrefs.GetInt("questHome") == 3)
        {
            SaveProfit();
            PlayerPrefs.SetInt("questHome", 4);
        }
        else if (PlayerPrefs.GetInt("hous") >= 50 && PlayerPrefs.GetInt("questHome") == 4)
        {
            SaveProfit();
            PlayerPrefs.SetInt("questHome", 5);
        }
        ShowQuest();
    }

    private void SaveProfit()
    {
        PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter")
                + ProfitQuest[PlayerPrefs.GetInt("questHome")]
                * (PlayerPrefs.GetFloat("profitMaraStatue") + PlayerPrefs.GetFloat("profitGooseCap")));
    }


}
