using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderSplash : MonoBehaviour
{
    public Animator transition;
    public static bool GameIsPaused;
    public float transitionTime = 1f;

    public float pressToStartBekle = 4f;
    public GameObject kapatmasorusu;

    public GameObject baslamabutonu;

    public GameObject pressToStartYazi;
    public string sahneadi;

    void Start()
    {
        Time.timeScale=1f;
        GameIsPaused=true;
        kapatmasorusu.SetActive(false);
        baslamabutonu.SetActive(true);
        starttusuaktif();
    }
    void Update()
    {
        /*if(Input.GetMouseButtonDown(0))
        {
            LoadNextLevel();
        }*/
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                quitgamescreenon();
            }
            else
            {
                quitgamescreenoff();
            }    
        }
    }

    public void ekranbutonubasma()
    {
        LoadNextLevel();
    }
    public void oyungeritusu()
    {
        if(GameIsPaused)
        {
            quitgamescreenon();
        }
        else
        {
            quitgamescreenoff();
        }   
    }
    public void quitgamescreenon()
    {
        kapatmasorusu.SetActive(true);
        baslamabutonu.SetActive(false);
        GameIsPaused=false;
    }
    public void quitgamescreenoff()
    {
        kapatmasorusu.SetActive(false);
        baslamabutonu.SetActive(true);
        GameIsPaused=true;
        Debug.Log("offquit");
    }

    public void oyunukapat()
    {
        Debug.Log("quitgame");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel());
    }
    public void starttusuaktif()
    {
        StartCoroutine(PressToStartAktifEdici());
    }
    public IEnumerator PressToStartAktifEdici()
    {
        yield return new WaitForSeconds(pressToStartBekle);
        pressToStartYazi.SetActive(true);
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(sahneadi); 

    }
}
