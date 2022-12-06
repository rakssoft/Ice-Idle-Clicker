using UnityEngine;
using Spine;
using Spine.Unity;

public class Goose : MonoBehaviour
{
    [SerializeField] private SkeletonAnimation _gooseAnim;



    private void OnEnable()
    {
        Events.AnimGoose += PlayAnim;
    }

    private void OnDisable()
    {
        Events.AnimGoose -= PlayAnim;
    }

    private void PlayAnim(string animName, bool loop)
    {
        _gooseAnim.AnimationState.SetAnimation(0, animName, loop);
    }
}