using UnityEngine.EventSystems;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _modalWindow;
    [SerializeField] private Transform _parentSpawn;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)), Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.CompareTag("upgradedbuilding"))
                {
                    Instantiate(_modalWindow, hit.transform.position, Quaternion.identity, _parentSpawn);
                  
                }
            }
        }
    }
}
