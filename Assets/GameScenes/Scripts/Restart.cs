using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {


	void Update () {
        if (Input.GetKeyDown(KeyCode.R)){
            SFXManager.sfxManager.Audio.PlayOneShot(SFXManager.sfxManager.Click);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SFXManager.sfxManager.Audio.PlayOneShot(SFXManager.sfxManager.Click);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
