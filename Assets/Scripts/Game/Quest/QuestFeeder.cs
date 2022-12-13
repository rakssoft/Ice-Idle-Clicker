using UnityEngine;
using UnityEngine.UI;

public class QuestFeeder : MonoBehaviour
{
    [SerializeField] private Button _complitButton;
    [SerializeField] private Text _textButton;
    [SerializeField] private Text _descriptionQuestText;
    [SerializeField] private Text _profitQuestText;
    private string[] DecsQuest = new[] { "Купить кормушку для гусынь 5 уровня",
                                         "Купить кормушку для гусынь 10 уровня",
                                         "Купить кормушку для гусынь 15 уровня"};
    private int[] ProfitQuest = new int[] { 50, 60, 70};
    private int _currentLvlQuest;

    public void ShowQuest()
    {
        if (PlayerPrefs.GetInt("questFeeder") == 3)
        {
            _complitButton.interactable = false;
            _textButton.text = "выполнено".ToString();
        }
        else
        {
            _currentLvlQuest = PlayerPrefs.GetInt("questFeeder");
            _descriptionQuestText.text = DecsQuest[_currentLvlQuest].ToString();
            _profitQuestText.text = ProfitQuest[_currentLvlQuest].ToString();
        }


    }

    public void CompleteQuest()
    {

        if (PlayerPrefs.GetInt("feeder") >= 5 && PlayerPrefs.GetInt("questFeeder") == 0)
        {
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") + ProfitQuest[PlayerPrefs.GetInt("questFeeder")] * PlayerPrefs.GetFloat("profitMaraStatue"));
            PlayerPrefs.SetInt("questFeeder", 1);
        }
        else if (PlayerPrefs.GetInt("feeder") >= 10  &&  PlayerPrefs.GetInt("questFeeder") == 1)
        {
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") + ProfitQuest[PlayerPrefs.GetInt("questFeeder")] * PlayerPrefs.GetFloat("profitMaraStatue"));
            PlayerPrefs.SetInt("questFeeder", 2);
        }
        else if (PlayerPrefs.GetInt("feeder") >= 15 && PlayerPrefs.GetInt("questFeeder") == 2)
        {
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") + ProfitQuest[PlayerPrefs.GetInt("questFeeder")] * PlayerPrefs.GetFloat("profitMaraStatue"));
            PlayerPrefs.SetInt("questFeeder", 3);
        }

        ShowQuest();
    }
}
