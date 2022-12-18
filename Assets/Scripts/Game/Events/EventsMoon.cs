using UnityEngine;
using Spine;
using Spine.Unity;
using System.Collections;

public class EventsMoon : MonoBehaviour
{

    [SerializeField] private SkeletonAnimation _moonAnim;
    private string[] _comments = new[] { "√оспожа благословила нас, прирост €иц увеличилс€.",
        "—вет луны благотворно вли€ет на гусынь, они несут больше €иц.", "ѕри €рком свете луны мы получаем больше €иц." };
   
    private void OnEnable()
    {
        Events.AnimMoon += PlayAnim;
    }

    private void OnDisable()
    {
        Events.AnimMoon -= PlayAnim;
    }

    private void PlayAnim(string animName, bool loop)
    {
        _moonAnim.AnimationState.SetAnimation(0, animName, loop);
        _moonAnim.AnimationState.AddAnimation(0, "bg_sky_idle", true, 0);
    }

    public void StartEvents()
    {
        Events.EventBuffClick?.Invoke(5);
        PlayAnim("bg_sky_event", false);
        int Idcomment = Random.Range(0, 2);
        Events.Comment?.Invoke(_comments[Idcomment]);
        Events.IsComment?.Invoke(false);
        Events.MusicPlay?.Invoke(2);
        StartCoroutine(EndEvents());
    }



    IEnumerator EndEvents()
    {
        yield return new WaitForSeconds(15f);
        Events.IsComment?.Invoke(true);
        Events.MusicPlay?.Invoke(0);
        Events.EventOff?.Invoke(true);
        Events.EventBuffClick?.Invoke(1);
    }
}
