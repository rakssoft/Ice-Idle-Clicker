using System.Collections;
using UnityEngine;

public class LoveEvent : MonoBehaviour
{
    [SerializeField] private GameObject _mainGoose, _goose1, _goose2;
    [SerializeField] private GameObject _spawnGoose1, _spawnGoose2;
    [SerializeField] private GameObject _windowRomantik, _gooseMadamWindow;
    [SerializeField] private GameObject _hearts;
    [SerializeField] private GameObject _panelOffClick;
    private string[] _comments = new[] { "Я скоро, нужно посчитать гусынь",
                                         "Меня тут одна гусыня пригласила на чай, отлучусь ненадолго.",
                                         "Ночь сегодня особенно прекрасна, она зовет меня на приключения.",
                                         "У меня появились срочные и важные дела, присмотри тут за всем.",
                                         "Мне надо... эээ... убедиться, что гусыням комфортно в избушке."};

    private string[] _comments2 = new[] { "Теперь яиц будет много... на половину",
                                           "Собирай яйца пока  гусыни добрые...",
                                            "Так вышло, что прирост яиц увеличился.",
                                            "Скорее собирай яйца, пока есть возможность!"};
    public void StartEvents()
    {
        int Idcomment = Random.Range(0, 2);
        Events.Comment?.Invoke(_comments[Idcomment]);
        Events.IsComment?.Invoke(false);
        _goose1.transform.position = _spawnGoose1.transform.position;
        _goose2.transform.position = _spawnGoose2.transform.position;
        _hearts.SetActive(false);
        _windowRomantik.SetActive(false);
        _gooseMadamWindow.SetActive(true);
        _mainGoose.SetActive(false);
        _panelOffClick.SetActive(true);
        _goose1.SetActive(true);
        _goose2.SetActive(true);
        Events.MusicPlay?.Invoke(2);
        StartCoroutine(BeginEvent());
        
    }

    private IEnumerator BeginEvent()
    {
        yield return new WaitForSeconds(4);
        Events.AnimGooseMadamWindow?.Invoke("romantik_window_goose_madam", false);
        yield return new WaitForSeconds(3);
        _windowRomantik.SetActive(true);
        _gooseMadamWindow.SetActive(false);
        _hearts.SetActive(true);
        yield return new WaitForSeconds(3);
        _hearts.SetActive(false);
        _windowRomantik.SetActive(false);
        _gooseMadamWindow.SetActive(true);
        Events.AnimGooseMadamWindow?.Invoke("romantik_window_goose_madam2", false);
        yield return new WaitForSeconds(2);
        _mainGoose.SetActive(true);
        _panelOffClick.SetActive(false);
        int Idcomment = Random.Range(0, 2);
        Events.Comment?.Invoke(_comments2[Idcomment]);
        Events.GameEventsBuff?.Invoke(1.5f);
        Events.EventBuffClick?.Invoke(3);
        Events.AnimMoon?.Invoke("bg_sky_event", false);
        StartCoroutine(EndEvents());

    }

    IEnumerator EndEvents()
    {
        yield return new WaitForSeconds(15f);
        Events.GameEventsBuff?.Invoke(1f);
        Events.EventBuffClick?.Invoke(1);
        Events.IsComment?.Invoke(true);
        Events.MusicPlay?.Invoke(0);
        Events.EventOff?.Invoke(true);
        StopCoroutine(BeginEvent());
        StopCoroutine(EndEvents());
        gameObject.SetActive(false);
    }








}
