using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public GameObject swing;
    public static bool turn;
    public int speed;
    void Start()
    {
        turn = true;
    }

    
    void Update()
    {

        if (turn)
        {
            swing.transform.Rotate(0f, speed, 0f);
        }
        else
        {
            swing.transform.Rotate(0f, 0f, 0f);
        }
        
    }

    private void OnTriggerStay(Collider other) {
        if(other.CompareTag("player")){
            turn = false;
        }
    }

     private void OnTriggerExit(Collider other) {
         if(other.CompareTag("player")){
            StartCoroutine(Delay(2f));
        }
        
    }


/*    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("player"))
        {

            turn = false;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.collider.CompareTag("player"))
        {

            StartCoroutine(Delay(2f));
        }
    }*/
     IEnumerator Delay(float time)
 {
     yield return new WaitForSeconds(time);
 
     turn = true;
 }
}
