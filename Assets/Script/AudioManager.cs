using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    private AudioSource bgm;
    [SerializeField] private Toggle muteToggle;

    private void Start()
    {
        bgm = GetComponent<AudioSource>();
        muteToggle.isOn = false;
    }

    public void Mute() //bool muted
    {
        if (muteToggle.isOn)
            bgm.mute = true;
        else
            bgm.mute = false;

        // if (muted)
        //     AudioListener.volume = 0;
        // else
        //     AudioListener.volume = 1;
    }

    public void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }

}
