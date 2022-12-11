using UnityEngine;
using Spine;
using Spine.Unity;
using System.Collections;

public class GooseMadam : MonoBehaviour
{
    [SerializeField] private SkeletonAnimation _gooseMadamAnim;
    private string[] AnimationsMadam = new[] { "dreams_goose_madam", "kru_goose_madam" };
    private string idle = "idle_goose_madam";
    // Start is called before the first frame update
    private void OnEnable()
    {
        Events.AnimGooseMadam += PlayAnim;
    }

    private void OnDisable()
    {
        Events.AnimGooseMadam -= PlayAnim;
    }

    private void Start()
    {
        PlayAnim(idle, false);
        StartCoroutine(ChoiseAnim());
    }

    private void PlayAnim(string animName, bool loop)
    {
        _gooseMadamAnim.AnimationState.SetAnimation(0, animName, loop);
        _gooseMadamAnim.AnimationState.AddAnimation(0, idle, true, 0);
    }

    IEnumerator ChoiseAnim()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            PlayAnim(AnimationsMadam[Random.Range(0, 2)], false);
        }
    }
}
