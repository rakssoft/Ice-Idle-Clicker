using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class EggText : MonoBehaviour
{
    [SerializeField] private Text _eggText;
    public float _eggCurrent;
    void Start()
    {
        _eggText.text = _eggCurrent.ToString();
        transform.DOLocalMove(new Vector3(-110, 650, 1), 5);
        transform.DOScale(new Vector3(0.3f, 0.3f, 1), 5);
        Destroy(gameObject, 5.2f);
    }
}
