using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSound : MonoBehaviour
{
    //Script para tocar a musica de fundo
    public static BackgroundSound bgSoundInstance;

    private void Awake()
    {
        if (bgSoundInstance != null && bgSoundInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        bgSoundInstance = this;
        DontDestroyOnLoad(this);
    }

}
