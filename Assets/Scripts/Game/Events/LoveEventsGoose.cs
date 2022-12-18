using UnityEngine;
using Spine.Unity;


public class LoveEventsGoose : MonoBehaviour
{
    [SerializeField] private Vector2 _speed;
    [SerializeField] private SkeletonAnimation _gooseAnim;


    private void FixedUpdate()
    {
        transform.Translate(_speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("hous"))
        {
            gameObject.SetActive(false);
        }
    }


}
