using UnityEngine;
using Spine;
using Spine.Unity;

public class HomeNew : MonoBehaviour
{
    [SerializeField] private SkeletonAnimation _homeAnim;
    // Start is called before the first frame update
    private void OnEnable()
    {
   
    }

    private void OnDisable()
    {
    
    }

    private void PlayAnim(string animName, bool loop)
    {
        _homeAnim.AnimationState.SetAnimation(0, animName, loop);
    }
}
