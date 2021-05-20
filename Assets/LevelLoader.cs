using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transtionTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //Executar a animação
        StartCoroutine(LoadTransition(SceneManager.GetActiveScene().buildIndex + 1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadTransition(int LevelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transtionTime);

        SceneManager.LoadScene(LevelIndex);
    }
}
