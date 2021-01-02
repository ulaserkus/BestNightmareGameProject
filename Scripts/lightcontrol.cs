using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightcontrol : MonoBehaviour
{
    public GameObject Light;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(OnOff());


    }



    IEnumerator OnOff()
    {
         Light.SetActive(false);

        yield return new WaitForSeconds(0.7f);

        Light.SetActive(true);

       


    }
}
