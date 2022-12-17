using UnityEngine;

using Spine.Unity;
using System.Collections;

public class MoranaLive : MonoBehaviour
{
    [SerializeField] private SkeletonAnimation _moranaAnim;

    private void Start()
    {
        SpeakMorana();
    }

    private void PlayAnim(string animName, bool loop)
    {
       _moranaAnim.AnimationState.SetAnimation(0, animName, loop);
        _moranaAnim.AnimationState.AddAnimation(0, "morana_live_idle", true, 0);
    }

    public void SpeakMorana()
    {
        PlayAnim("morana_live_speak", false);
    }

}
