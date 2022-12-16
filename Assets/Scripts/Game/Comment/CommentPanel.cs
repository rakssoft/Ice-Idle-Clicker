using UnityEngine.UI;
using UnityEngine;

public class CommentPanel : MonoBehaviour
{
    [SerializeField] private Text _commentText;
    public  string Commentary;


    public void ClosePanel()
    {
        gameObject.SetActive(false);
    }

    public void CommentDisplay(string com)
    {
        Commentary = com;
        _commentText.text = Commentary.ToString();
    }





}
