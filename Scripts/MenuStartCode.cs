using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStartCode : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public GameObject menusec;
    void Start()
    {
        menusec.SetActive(false);
        Time.timeScale=1f;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
             ayarlarPanelKapat();
        }
    }
    public void ayarlarPanelAc()
    {
        StartCoroutine(ayarPanelAc());
    }
    public void ayarlarPanelKapat()
    {
        StartCoroutine(ayarPanelKapat());
    }

    IEnumerator ayarPanelAc()
    {
        transition.SetTrigger("Basla");
        yield return new WaitForSeconds(transitionTime);
        menusec.SetActive(true);
    }
    IEnumerator ayarPanelKapat()
    {
        transition.SetTrigger("Basla");
        yield return new WaitForSeconds(transitionTime);
        menusec.SetActive(false);
    }

}