using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControler : MonoBehaviour
{
    public static MusicControler Instance;
    private AudioSource _audioSource;
    private void Awake()
    {
        if (Instance == null)
            {
                DontDestroyOnLoad(this);
                Instance = this;
                _audioSource = GetComponent<AudioSource>();
                GameObject.FindGameObjectWithTag("Music").GetComponent<MusicControler>().PlayMusic();
            }
            else
                Destroy(gameObject);
        
        
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}
