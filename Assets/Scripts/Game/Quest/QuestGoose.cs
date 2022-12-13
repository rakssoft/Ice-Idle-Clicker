using UnityEngine;
using UnityEngine.UI;

public class QuestGoose : MonoBehaviour
{
    [SerializeField] private Button _complitButton;
    [SerializeField] private Text _textButton;
    [SerializeField] private Text _descriptionQuestText;
    [SerializeField] private Text _profitQuestText;
    private string[] DecsQuest = new[] { "������ 10 ������",
                                         "������ 20 ������",
                                         "������ 30 ������",
                                         "������ 40 ������"};
    private int[] ProfitQuest = new int[] { 5, 10, 15, 20 };
    private int _currentLvlQuest;

    public void ShowQuest()
    {
        if (PlayerPrefs.GetInt("questGoose") == 4)
        {
            _complitButton.interactable = false;
            _textButton.text = "���������".ToString();
        }
        else
        {
            _currentLvlQuest = PlayerPrefs.GetInt("questGoose");
            _descriptionQuestText.text = DecsQuest[_currentLvlQuest].ToString();
            _profitQuestText.text = ProfitQuest[_currentLvlQuest].ToString();
        }


    }

    public void CompleteQuest()
    {

        if (PlayerPrefs.GetInt("goose") >= 10 &&  PlayerPrefs.GetInt("questGoose") == 0)
        {
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") + ProfitQuest[PlayerPrefs.GetInt("questGoose")] * PlayerPrefs.GetFloat("profitMaraStatue"));
            PlayerPrefs.SetInt("questGoose", 1);
        } 
       else if (PlayerPrefs.GetInt("goose") >= 20 &&  PlayerPrefs.GetInt("questGoose") == 1)
        {
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") + ProfitQuest[PlayerPrefs.GetInt("questGoose")] * PlayerPrefs.GetFloat("profitMaraStatue"));
            PlayerPrefs.SetInt("questGoose", 2);
        }
        else if (PlayerPrefs.GetInt("goose") >= 30  && PlayerPrefs.GetInt("questGoose") == 2)
        {
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") + ProfitQuest[PlayerPrefs.GetInt("questGoose")] * PlayerPrefs.GetFloat("profitMaraStatue"));
            PlayerPrefs.SetInt("questGoose", 3);
        }
        else if (PlayerPrefs.GetInt("goose") >= 40 &&  PlayerPrefs.GetInt("questGoose") == 3)
        {
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") + ProfitQuest[PlayerPrefs.GetInt("questGoose")] * PlayerPrefs.GetFloat("profitMaraStatue"));
            PlayerPrefs.SetInt("questGoose", 4);
        }

        ShowQuest();
    }

}
