using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seskod1 : MonoBehaviour
{
    public AudioClip arkases;
    AudioSource clickses;
    void Start()
    {
        clickses=GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public void clicksescal()
    {
        clickses.PlayOneShot(arkases, .7f);
    }
}
