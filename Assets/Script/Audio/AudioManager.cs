using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager audioInstance;

    public AudioClip[] clipBGM;
    public AudioSource BGM;

    private void Awake()
    {
        BGM = GetComponentInChildren<AudioSource>();

        if (audioInstance == null)
        {
            audioInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // BGM = GetComponentInChildren<AudioSource>();
        switchAudio();
    }

    public void switchAudio()
    {
        for (int i = 0; i < clipBGM.Length; i++)
        {
            if (i == SceneManager.GetActiveScene().buildIndex)
            {
                BGM.Pause();

                BGM.clip = clipBGM[i];
                BGM.Play();
            }
        }
    }

}
