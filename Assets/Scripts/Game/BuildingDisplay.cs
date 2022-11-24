
using UnityEngine;
using UnityEngine.UI;

public class BuildingDisplay : MonoBehaviour
{
    [SerializeField] private string _nameObject;
    [SerializeField] private Image _spriteObject;
    [SerializeField] private int _levelUpgrade;
    [SerializeField] private int _costUpgrade;
    [SerializeField] private string _description;




    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
