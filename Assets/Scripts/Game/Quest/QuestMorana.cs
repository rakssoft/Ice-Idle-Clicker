using UnityEngine;
using UnityEngine.UI;

public class QuestMorana : MonoBehaviour
{
    [SerializeField] private Button _complitButton;
    [SerializeField] private Text _textButton;
    [SerializeField] private Text _descriptionQuestText;
    [SerializeField] private Text _profitQuestText;
    [SerializeField] private GameObject _lockMaranaQuest;
    private string[] DecsQuest = new[] { "Моране требуется 500 яиц для ритуалов",
                                         "Моране требуется 1000 яиц для ритуалов",
                                         "Моране требуется 2000 яиц для ритуалов",
                                         "Моране требуется 4000 яиц для ритуалов",
                                         "Моране требуется 8000 яиц для ритуалов",};
    private int[] ProfitQuest = new int[] { 50, 100, 200, 400, 800 };
    private int _currentLvlQuest;

    public void ShowQuest()
    {
        if (PlayerPrefs.GetInt("questMorana") == 5)
        {
            _complitButton.interactable = false;
            _textButton.text = "выполнено".ToString();
        }
        else
        {
            _currentLvlQuest = PlayerPrefs.GetInt("questMorana");
            _descriptionQuestText.text = DecsQuest[_currentLvlQuest].ToString();
            _profitQuestText.text = ProfitQuest[_currentLvlQuest].ToString();
        }

    }
    public void CompleteQuest()
    {

        if (PlayerPrefs.GetFloat("egg") >= 500 && PlayerPrefs.GetInt("questMorana") == 0)
        {
            PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - 500 );
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") + ProfitQuest[PlayerPrefs.GetInt("questMorana")] * PlayerPrefs.GetFloat("profitMaraStatue"));
            PlayerPrefs.SetInt("questMorana", 1);
        }
       else if (PlayerPrefs.GetFloat("egg") >= 1000 && PlayerPrefs.GetInt("questMorana") == 1)
        {
            PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - 1000 );
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") + ProfitQuest[PlayerPrefs.GetInt("questMorana")] * PlayerPrefs.GetFloat("profitMaraStatue"));
            PlayerPrefs.SetInt("questMorana", 2);
        } 
        else if (PlayerPrefs.GetFloat("egg") >= 2000 && PlayerPrefs.GetInt("questMorana") == 2)
        {
            PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - 2000 );
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") + ProfitQuest[PlayerPrefs.GetInt("questMorana")] * PlayerPrefs.GetFloat("profitMaraStatue"));
            PlayerPrefs.SetInt("questMorana", 3);
        }   
        else if (PlayerPrefs.GetFloat("egg") >= 4000 && PlayerPrefs.GetInt("questMorana") == 3)
        {
            PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - 4000 );
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") + ProfitQuest[PlayerPrefs.GetInt("questMorana")] * PlayerPrefs.GetFloat("profitMaraStatue"));
            PlayerPrefs.SetInt("questMorana", 4);
        }
        else if (PlayerPrefs.GetFloat("egg") >= 8000 && PlayerPrefs.GetInt("questMorana") == 4)
        {
            PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg") - 8000 );
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") + ProfitQuest[PlayerPrefs.GetInt("questMorana")] * PlayerPrefs.GetFloat("profitMaraStatue"));
            PlayerPrefs.SetInt("questMorana", 5);
        }
        ShowQuest();
    }
}
