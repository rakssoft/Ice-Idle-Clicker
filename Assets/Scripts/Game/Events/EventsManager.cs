using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _eventsGame;

    private void OnEnable()
    {
        Events.TutorialOff += BeginEvents;
    }

    private void OnDisable()
    {
        Events.TutorialOff -= BeginEvents;
    }

    private void BeginEvents(bool eventsBegin)
    {
        if(eventsBegin == true)
        {
            StartCoroutine(ChoseEvent());
        }
    }

   private  IEnumerator ChoseEvent()
    {
        yield return new WaitForSeconds(Random.Range(20, 35));
        _eventsGame[Random.Range(0, _eventsGame.Length)].SetActive(true);

    }


}
