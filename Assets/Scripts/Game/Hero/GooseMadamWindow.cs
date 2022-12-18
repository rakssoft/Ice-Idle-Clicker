using System.Collections;
using UnityEngine;
using Spine.Unity;

public class GooseMadamWindow : MonoBehaviour
{
    [SerializeField] private SkeletonAnimation _gooseMadamAnimWindow;
    private string animationsMadam = "kru_window_goose_madam";
    private string idle = "idle_window_goose_madam";



    private void OnEnable()
    {
        Events.AnimGooseMadamWindow += PlayAnim;
        Events.GooseMadamSkin += Skin;
    }

    private void OnDisable()
    {
        Events.AnimGooseMadamWindow -= PlayAnim;
        Events.GooseMadamSkin -= Skin;
    }
    private void Start()
    {
        StartCoroutine(ChoiseAnim());
        PlayAnim("appearance_window_goose_madam", false);
        
    }

    private void PlayAnim(string animName, bool loop)
    {
        _gooseMadamAnimWindow.AnimationState.SetAnimation(0, animName, loop);
        _gooseMadamAnimWindow.AnimationState.AddAnimation(0, idle, true, 0);
    }

    IEnumerator ChoiseAnim()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(8, 12));
            PlayAnim("kru_window_goose_madam", false);
        }
    }

    private void Skin(string skin)
    {

        _gooseMadamAnimWindow.initialSkinName = skin;
        _gooseMadamAnimWindow.Initialize(true);
        PlayAnim("idle_window_goose_madam", false);
    }
}
