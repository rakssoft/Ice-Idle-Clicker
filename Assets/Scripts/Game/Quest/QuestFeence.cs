using UnityEngine;
using UnityEngine.UI;

public class QuestFeence : MonoBehaviour
{
    [SerializeField] private Button _complitButton;
    [SerializeField] private Text _textButton;
    [SerializeField] private Text _descriptionQuestText;
    [SerializeField] private Text _profitQuestText;
    private string[] DecsQuest = new[] { "Купить забор 1 уровня",
                                         "Купить забор 2 уровня",
                                         "Купить забор 3 уровня"};
    private int[] ProfitQuest = new int[] { 80, 90, 100 };
    private int _currentLvlQuest;

    public void ShowQuest()
    {
        if (PlayerPrefs.GetInt("questFence") == 3)
        {
            _complitButton.interactable = false;
            _textButton.text = "выполнено".ToString();
        }
        else
        {
            _currentLvlQuest = PlayerPrefs.GetInt("questFence");
            _descriptionQuestText.text = DecsQuest[_currentLvlQuest].ToString();
            _profitQuestText.text = ProfitQuest[_currentLvlQuest].ToString();
        }
 

    }

    public void CompleteQuest()
    {

        if (PlayerPrefs.GetInt("fence") >= 1 &&  PlayerPrefs.GetInt("questFence") == 0)
        {
            SaveProfit();
            PlayerPrefs.SetInt("questFence", 1);
        }
        else if (PlayerPrefs.GetInt("fence") >= 2  && PlayerPrefs.GetInt("questFence") == 1)
        {
            SaveProfit();
            PlayerPrefs.SetInt("questFence", 2);
        }
        else if (PlayerPrefs.GetInt("fence") >= 3 &&  PlayerPrefs.GetInt("questFence") == 2)
        {
            SaveProfit();
            PlayerPrefs.SetInt("questFence", 3);
        }
        ShowQuest();
    }

    private void SaveProfit()
    {
        PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter")
                + ProfitQuest[PlayerPrefs.GetInt("questFence")]
                * (PlayerPrefs.GetFloat("profitMaraStatue") + PlayerPrefs.GetFloat("profitGooseCap")));
    }
}
