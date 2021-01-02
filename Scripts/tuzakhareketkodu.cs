using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuzakhareketkodu : MonoBehaviour
{
    
    public bool sag_sol;
    public bool ileri_geri;
    public bool don;

    public float hareket_hizi;
    public float donme_hizi;

    
    

   
    void Update()
    {
        if(sag_sol==true)
        {
            transform.Translate(hareket_hizi*Time.deltaTime,0,0,Space.World);
        }
        if(ileri_geri==true)
        {
            transform.Translate(0,0,hareket_hizi*Time.deltaTime,Space.World);
        }
        if(don==true)
        {
            transform.Rotate(0,donme_hizi*Time.deltaTime,0,Space.World);
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "zemin")
            hareket_hizi *= -1;
    }


}
