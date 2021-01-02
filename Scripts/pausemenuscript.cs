using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pausemenuscript : MonoBehaviour
{

    public static bool GameIsPaused=false;
    
    public GameObject pauseMenuUI;
    public Animator transition;
    public float transitionTime = 1f;

    public string YuklenecekRestartAdi;
    public string YuklenecekMenuAdi;

//    private float durZamanHiz=Time.timeScale

    void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }


        if(GameIsPaused==true)
        {
                if(Input.GetKeyDown(KeyCode.M))
                {
                LoadMenu();
                }
                if(Input.GetKeyDown(KeyCode.Q))
                {
                QuitMenu();
                }
                if(Input.GetKeyDown(KeyCode.R))
                {
                RestartMenu();
                }
        }
        
        
    }
        public void DurButonunaTiklandi()
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale=Time.timeScale*25;
        GameIsPaused=false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale=Time.timeScale/25;
        GameIsPaused=true;
    }

    public void LoadMenu()
    {
        GameIsPaused=false;
        Time.timeScale=1f;
        StartCoroutine(LoadLevel());
    }
    public void RestartMenu()
    {
        GameIsPaused=false;
        Time.timeScale=1f;
        StartCoroutine(RestartLevel());
    }
    
    public void QuitMenu()
    {
        GameIsPaused=false;
        Time.timeScale=1f;
        Application.Quit();
    }
    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(YuklenecekMenuAdi); 

    }
    IEnumerator RestartLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(YuklenecekRestartAdi); 

    }
}
