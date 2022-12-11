using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.Events;

public class InputPlayer : MonoBehaviour
{
    [HideInInspector] [SerializeField] private CoinManager _coinManager;
    private InputSystems _inputSystem;
    public Vector2 MousePositions { get; private set; }
    public InputSystems Input => _inputSystem;
    public static UnityAction<float> click;


    public void OnEnable()
    {
        _inputSystem.Enable();
    }
    public void OnDisable()
    {
        _inputSystem.Disable();
    }

    private void Awake()
    {
        _inputSystem = new InputSystems();
        //    _inputSystem.Player.Touch.performed += ctx => TouchPlayer();
    }

    private void Update()
    {
        MousePositions = _inputSystem.Player.MousePositions.ReadValue<Vector2>();
        if (_inputSystem.Player.Touch.WasPerformedThisFrame() && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(new Vector3(MousePositions.x, MousePositions.y, 10)), Vector2.zero, 10, -5);
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.TryGetComponent(out Coins coinsGameObject))
                {
                    click?.Invoke(1);
                    //   _coinManager.RecalEggs(1);
                } 
                if (hit.collider.gameObject.TryGetComponent(out Goose goose))
                {
                 
                }
            }
        }

    }

    public void ClickButtonUI()
    {

        click?.Invoke(1);
        Events.AnimGooseMadam?.Invoke("egg_goose_madam", true);
        Events.AnimHouseClick?.Invoke();
        Events.SoundPlay?.Invoke(1);
    } 
    public void ClickButtonUIHous()
    {

        Events.ClickHous?.Invoke(1);
        Events.AnimHouseClick?.Invoke();
        Events.SoundPlay?.Invoke(1);
    }

}
