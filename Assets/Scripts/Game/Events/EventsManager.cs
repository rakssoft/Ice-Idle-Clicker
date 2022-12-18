using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _eventsGame;
    private bool eventsCur;
    private void OnEnable()
    {
        Events.TutorialOff += BeginEvents;
        Events.EventOff += BeginEvents;
    }

    private void OnDisable()
    {
        Events.TutorialOff -= BeginEvents;
        Events.EventOff -= BeginEvents;
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
        yield return new WaitForSeconds(Random.Range(30, 35));
        int random = Random.Range(0, _eventsGame.Length);
         _eventsGame[random].SetActive(true);
        if (_eventsGame[random].GetComponent<WolfEvents>())
        {
            _eventsGame[random].GetComponent<WolfEvents>().Start();
        }
        else if (_eventsGame[random].GetComponent<EventsMoon>())
        {
            _eventsGame[random].GetComponent<EventsMoon>().StartEvents();
        }
        else if (_eventsGame[random].GetComponent<LoveEvent>())
        {
            _eventsGame[random].GetComponent<LoveEvent>().StartEvents();
        }
        

    }


}
