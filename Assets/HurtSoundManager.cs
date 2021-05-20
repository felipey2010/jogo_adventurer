using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtSoundManager : MonoBehaviour
{
    //Play audio when collide with enemy

    public AudioSource Hurt;

    public AudioClip HurtSound;

    public static HurtSoundManager hurtManager;

    private void Awake()
    {
        if (hurtManager != null && hurtManager != this)
        {
            Destroy(this.gameObject);
            return;
        }

        hurtManager = this;
        DontDestroyOnLoad(this);
    }
}
