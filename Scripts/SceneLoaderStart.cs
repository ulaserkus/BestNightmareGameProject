using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoaderStart : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;
    public float animasyonbekle = 4f;

    public string sahneadi;


    void Start(){

        Time.timeScale=1f;

        StartCoroutine(LoadNextLevel());

    }
    public IEnumerator LoadNextLevel()
    {
        yield return new WaitForSeconds(animasyonbekle);
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel(/*int levelIndex*/)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(sahneadi); 

    }
}
