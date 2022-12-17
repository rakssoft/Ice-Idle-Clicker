using UnityEngine;
using Spine;
using Spine.Unity;
using System.Collections;

public class Goose : MonoBehaviour
{
    [SerializeField] private SkeletonAnimation _gooseAnim;
    private string[] _comments = new[] { "������ ������ ������, �� �������� �����. � �� ��������...",
                                                          "���� �������� �����, ������� ����� ������ ������ �������� ����.",
                                                          "������� ����, �������, ��������, �� ����� ��������� �� � �������� �� ���-�� ��������.",
                                                          "���� ������ ���� �����, ����� ������� ����� ����� ���.",
                                                          "�������� ������� �� ������ ������ ����, �� � ����������� ������� ���.",
                                                          "��� ������� ��� � ��������, ��� ������ ��� ���� ������.",
                                                          "������ ������� ��� �� ��������. ��������, ������� ��������.",
                                                          "����! ����! ��-��, � �������. ��� �� �������? ��?! ��!",
                                                          "����� ������������. ���-�� �������� ������, � ���-�� ����� ������...",
                                                          "����� �� ���� � ������ ���� ����� ��� �����������?",
                                                          "� �� ������, ��� � ������� ���� ������? ��� �� ����� �����, � ���������.",
                                                          "� ������ �� �������� ������ ����� ������. �������� ������.",
                                                          "������� ����� ����� ����� ������. �� ������� �����������, ��.",
                                                          "� ��� ��� ��� �� �����, � ��������� ����� �����-�� ������ �������. ��� �������.",
                                                          "���� ������, ��� ���� ���� � �� ���� ��������. �� �� ������ ����� ���������.",
                                                          "� ������ ������� ���� ��������� �������� ��������� ����. �� ������ �� ���������.",
                                                          "��� ������� ��� ��� ��� ���������? ���� � ��� ����. ����� ��� � ������ ��� ��� ������.",
                                                          "���� � � ��� ������... �� � ����. ��� ���� �����." };
    private bool _isCommentTry;

    private void OnEnable()
    {
        Events.AnimGoose += PlayAnim;
        Events.GooseSkin += Skin;
        Events.IsComment += BeginComment;
        Events.TutorialOff += TutorialOff;
    }

    private void OnDisable()
    {
        Events.AnimGoose -= PlayAnim;
        Events.GooseSkin += Skin;
        Events.IsComment -= BeginComment;
        Events.TutorialOff -= TutorialOff;
    }

    private void BeginComment(bool IsBool)
    {
        _isCommentTry = IsBool;           
    }

    private void TutorialOff(bool of)
    {
        StartCoroutine(PublicComment());
        _isCommentTry = of;
    }


    IEnumerator PublicComment()
    {
        while (true)
        {
            yield return new WaitForSeconds(18);
            if(_isCommentTry == true)
            {
                int Idcomment = Random.Range(0, _comments.Length);
                Events.Comment?.Invoke(_comments[Idcomment]);
                int IdleRandom = Random.Range(1, 3);
                PlayAnim("speak" + IdleRandom, false);
            }
        }
        

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