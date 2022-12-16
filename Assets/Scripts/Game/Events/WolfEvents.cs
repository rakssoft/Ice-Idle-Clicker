using UnityEngine;
using Spine;
using Spine.Unity;
using System.Collections;

public class WolfEvents : MonoBehaviour
{
    [SerializeField] private GameObject _panelClick;
    [SerializeField] private SkeletonAnimation _wolfAnim;
    [SerializeField] private string IdleAnimWolf;
    [SerializeField] private string ClickAnimWolf;
    private string[] _comments = new[] { "Опять этот негодяй! Стукни его скорее!", "Волк! Волк!  Отгони его, он пугает гусынь!" };
    private float _debuffWolf;
    public void Start()
    {
        if (PlayerPrefs.GetInt("beads") == 0)
        {
            Events.GameEventsBuff?.Invoke(0.01f);
        }
        else if (PlayerPrefs.GetInt("beads") == 1)
        {
            Events.GameEventsBuff?.Invoke(0.5f);
        }
        int Idcomment = Random.Range(0, 2);
        Events.Comment?.Invoke(_comments[Idcomment]);
        Events.IsComment?.Invoke(false);
        Events.MusicPlay?.Invoke(1);
        _panelClick.SetActive(true);
    }

    


    
    private void PlayAnim(string animName, bool loop)
    {
        _wolfAnim.AnimationState.SetAnimation(0, animName, loop);
        _wolfAnim.AnimationState.AddAnimation(0, IdleAnimWolf, true, 0);
    }

    public void ClickWolfEndEvents()
    {
        PlayAnim(ClickAnimWolf, true);
        Events.GameEventsBuff?.Invoke(1f);
        _panelClick.SetActive(false);
        StartCoroutine(EndEvents());

    }

    IEnumerator EndEvents()
    {
        yield return new WaitForSeconds(1f);
        Events.IsComment?.Invoke(true);
        Events.MusicPlay?.Invoke(0);
        Events.EventOff?.Invoke(true);
        gameObject.SetActive(false);


    }

}
