using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip[] _soundEffect;

    private void OnEnable()
    {
        Events.SoundPlay += PlaySounds; 
    }

    private void OnDisable()
    {
        Events.SoundPlay -= PlaySounds;
    }


    /// <summary>
    /// ID 0- звук кнопок
    /// ID 1 звук тапу по дому или гусыни 
    /// ID 2 -звук кнопки в диалогах
    /// </summary>
    /// <param name="idSound"></param>
    public  void PlaySounds(int idSound)
    {
        _audioSource.PlayOneShot(_soundEffect[idSound]);
    } 
}
