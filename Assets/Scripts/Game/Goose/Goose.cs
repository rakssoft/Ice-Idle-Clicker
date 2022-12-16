using UnityEngine;
using Spine;
using Spine.Unity;
using System.Collections;

public class Goose : MonoBehaviour
{
    [SerializeField] private SkeletonAnimation _gooseAnim;
    private string[] _comments = new[] { "Десять гусынь хорошо, но двадцать лучше. А уж тридцать...",
                                                          "Если улучшить тотем, Госпожа будет давать больше Осколков зимы.",
                                                          "Осколки зимы, конечно, красивые, но лучше потратить их в магазине на что-то полезное.",
                                                          "Пока черная луна сияет, можно собрать очень много яиц.",
                                                          "Красивая избушка не только радует глаз, но и увеличивает прирост яиц.",
                                                          "Чем вкуснее еда в кормушке, тем больше яиц дают гусыни.",
                                                          "Стащил немного еды из кормушки. Вкуснота, перышки оближешь.",
                                                          "Волк! Волк! Хе-хе, я пошутил. Что ты делаешь? Эй?! Ай!",
                                                          "Время относительно. Где-то проходит минута, а где-то целая неделя...",
                                                          "Может ли каша в голове быть пищей для размышлений?",
                                                          "А ты знаешь, что у Госпожи есть сестра? Они не очень ладят, к сожалению.",
                                                          "А раньше мы разоряли гнезда диких гусынь. Прогресс налицо.",
                                                          "Сегодня видел очень милую гусыню. Но подойти постеснялся, эх.",
                                                          "С тех пор как ты здесь, я постоянно слышу какие-то голоса вдалеке. Мне страшно.",
                                                          "Люди думают, что гуси злые и на всех нападают. Но мы просто хотим обнимашек.",
                                                          "В каждом ледяном яйце заключена огромная волшебная сила. Не разбей их ненароком.",
                                                          "Кто продает нам все эти улучшения? Кабы я сам знал. Кроме нас и гусынь тут нет никого.",
                                                          "Если б я был султан... Но я гусь. Так даже лучше." };
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