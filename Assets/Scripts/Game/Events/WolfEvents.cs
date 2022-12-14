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
    void Start()
    {
        Events.GameEventsBuff?.Invoke(0.5f);
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
        Events.MusicPlay?.Invoke(0);
        Events.TutorialOff?.Invoke(true);
        gameObject.SetActive(false);
    }

}
