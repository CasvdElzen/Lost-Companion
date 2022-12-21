using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music2scene : MonoBehaviour
{
    private AudioSource _audioSource;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        _audioSource = GetComponent<AudioSource>();
        GameObject.FindGameObjectWithTag("Music").GetComponent<music2scene>().PlayMusic();
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
