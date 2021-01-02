using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoaderLoadMenu : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public string sahneadi;
    public Button butonsecimi;
    public Button butonsecimi2;
    public string levelkontrol;
    public int levelunlockolsunmu;



    void Start()
    {
        Time.timeScale=1f;
        if(levelunlockolsunmu==1)
        {
            butonsecimi.interactable=true;
            butonsecimi2.interactable=true;
        }
        else
        {
            if(PlayerPrefs.GetInt(levelkontrol)==1)
            {
                butonsecimi.interactable=true;
                butonsecimi2.interactable=true;
            }
            else
            {
                butonsecimi.interactable=false;
                butonsecimi2.interactable=false;
            }
        }
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
