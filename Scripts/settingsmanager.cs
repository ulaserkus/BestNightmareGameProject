using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingsmanager : MonoBehaviour
{
    public Text cozunurluk1;
    public Text cozunurluk2;

    string klt;
    string coz;

    int genislik;
    int yukseklik;

    void Start()
    {
        if(PlayerPrefs.GetInt(klt)==1)
        {
            kalitelow();
        }
        else if(PlayerPrefs.GetInt(klt)==2)
        {
            kalitemedium();
        }
        else if(PlayerPrefs.GetInt(klt)==3)
        {
            kalitehigh();
        }
        else{QualitySettings.SetQualityLevel(4);}



        if(PlayerPrefs.GetInt(coz)>=1)
        {
            int cozhesapdeger=PlayerPrefs.GetInt(coz);
            cozhesapla(cozhesapdeger);
        }
        else{cozvarsayilan();}

        cozunurluk1.text=genislik+"";
        cozunurluk2.text=yukseklik+"";

    }

   void Update()
    {
        cozunurluk1.text=genislik+"";
        cozunurluk2.text=yukseklik+"";
    }

    public void kalitelow()
    {
        QualitySettings.SetQualityLevel(3);
        PlayerPrefs.SetInt(klt,1);
    }
    public void kalitemedium()
    {
        QualitySettings.SetQualityLevel(4);
        PlayerPrefs.SetInt(klt,2);
    }
    public void kalitehigh()
    {
        QualitySettings.SetQualityLevel(6);
        PlayerPrefs.SetInt(klt,3);
    }
    
    public void cozvarsayilan()
    {
        yukseklik=Screen.height;
        genislik=Screen.width;
        Screen.SetResolution(genislik,yukseklik,true);
    }
    public void varsayilanayarlaradon()
    {
        cozvarsayilan();
        QualitySettings.SetQualityLevel(4);
    }
    public void cozhesapla(float value)
    {
        int xDegerGelen=Mathf.RoundToInt(value);
        yukseklik=(Screen.height*xDegerGelen)/100;
        genislik=((Screen.currentResolution.width*yukseklik)/Screen.currentResolution.height);
        Screen.SetResolution(genislik,yukseklik,true);
        PlayerPrefs.SetInt(coz,xDegerGelen);
    }
}

