using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip[] _soundEffect;

    private void OnEnable()
    {
        Events.MusicPlay += PlayMusic;
    }

    private void OnDisable()
    {
        Events.MusicPlay -= PlayMusic;
    }




    /// <summary>
    /// ID 0- �������� ������
    /// ID 1  ������� ������ �����
    /// ID 2 -���� ������ � ��������
    /// </summary>
    /// <param name="idSound"></param>
    public void PlayMusic(int idSound)
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_soundEffect[idSound]);
     
    }
}
