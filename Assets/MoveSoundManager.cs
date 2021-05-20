using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSoundManager : MonoBehaviour
{
    //The sound to play when player moves up or down
    public AudioSource Audio;

    public AudioClip Clip;

    public static MoveSoundManager moveSound;

    private void Awake()
    {
        if (moveSound != null && moveSound != this)
        {
            Destroy(this.gameObject);
            return;
        }

        moveSound = this;
        DontDestroyOnLoad(this);
    }
}
