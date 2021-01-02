using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCheck : MonoBehaviour
{
   private Rigidbody rigidbody;
    
    public AudioSource source;
    public AudioClip treeFall;
    
    void Start()
    {
        rigidbody = this.gameObject.GetComponent<Rigidbody>();
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            rigidbody.constraints = RigidbodyConstraints.None;
            source.PlayOneShot(treeFall);
            gameObject.GetComponent<SphereCollider>().enabled = false;
        }
    }
}
