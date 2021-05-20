using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SFXManager.sfxManager.Audio.PlayOneShot(SFXManager.sfxManager.Click);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        SFXManager.sfxManager.Audio.PlayOneShot(SFXManager.sfxManager.Click);
        Application.Quit();
    }
}
