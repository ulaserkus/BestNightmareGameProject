using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBreak : MonoBehaviour
{
    public GameObject parent;
    public GameObject partToVanish;
    public GameObject replacement;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("player"))
        {
            GameObject.Instantiate(replacement, parent.transform.position, parent.transform.rotation);
            StartCoroutine(Delay(0.8f));
            Destroy(partToVanish,0.8f);
           
        }
    }*/

     private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("player")){
            GameObject.Instantiate(replacement, parent.transform.position, parent.transform.rotation);
            Destroy(partToVanish,0.8f);
        }
    }

     IEnumerator Delay(float time)
 {
     yield return new WaitForSeconds(time);
     GameObject.Instantiate(replacement, transform.position, transform.rotation);
     // Code to execute after the delay
 }
}