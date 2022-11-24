using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerScene : MonoBehaviour
{
    [SerializeField] private GameObject _loadingScreen;

    private void Start()
    {
        if (_loadingScreen)
        {
            _loadingScreen.SetActive(false);
        }
     
    }
    public void PlayGame()
    {
        if (_loadingScreen)
        {
            _loadingScreen.SetActive(true);
        }
        StartCoroutine(LoadScreen());
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }

    public void ExitMainScene()
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator LoadScreen()
    {
        AsyncOperation acyncLoad = SceneManager.LoadSceneAsync(1);
        while (!acyncLoad.isDone)
        {
            yield return null;
        }
    }
}
