using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class CommentaryGoose : MonoBehaviour
{
    [SerializeField] private CommentPanel _commentPanelPrefab;
    

    private void OnEnable()
    {
        Events.Comment += ActiveComment;
    }

    private void OnDisable()
    {
        Events.Comment -= ActiveComment;
    }


    private void ActiveComment(string comment)
    {           
        _commentPanelPrefab.gameObject.SetActive(true);
        _commentPanelPrefab.CommentDisplay(comment);
        StartCoroutine(ClosePanel());
    }

    IEnumerator ClosePanel()
    {
        yield return new WaitForSeconds(5f);
        _commentPanelPrefab.gameObject.SetActive(false);
        _commentPanelPrefab.Commentary = "";
    }

}
