using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource Audio;

    public AudioClip Click;

    public static SFXManager sfxManager;

    private void Awake()
    {
        if (sfxManager != null && sfxManager != this)
        {
            Destroy(this.gameObject);
            return;
        }

        sfxManager = this;
        DontDestroyOnLoad(this);
    }
}
