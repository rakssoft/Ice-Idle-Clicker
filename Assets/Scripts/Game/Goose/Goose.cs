using UnityEngine;
using Spine;
using Spine.Unity;

public class Goose : MonoBehaviour
{
    [SerializeField] private SkeletonAnimation _gooseAnim;



    private void OnEnable()
    {
        Events.AnimGoose += PlayAnim;
        Events.GooseSkin += Skin;
    }

    private void OnDisable()
    {
        Events.AnimGoose -= PlayAnim;
        Events.GooseSkin += Skin;
    }

    private void PlayAnim(string animName, bool loop)
    {
        int IdleRandom = Random.Range(1, 4);
        _gooseAnim.AnimationState.SetAnimation(0, animName, loop);
        _gooseAnim.AnimationState.AddAnimation(0, "idle" + IdleRandom, true, 0);
    }

    private void Skin(string skin)
    {

        _gooseAnim.initialSkinName = skin;
        _gooseAnim.Initialize(true);
        PlayAnim("idle1", false);
    }
}