using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoaderMenu : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public string sahneadi;
    public Button butonsecimi;

    void Start()
    {
        Time.timeScale=1f;
        butonsecimi.interactable=true;
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel());
       
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sahneadi); 
    }
}
