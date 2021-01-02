using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAnimator : MonoBehaviour
{
    public Animator animator;

    public static bool silent;

    public Rigidbody rigidbody;

    public bool jumping;

    public AudioSource source;

    void Start()
    {
       jumping = false;
        
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) ||Input.GetKey(KeyCode.D) ||Input.GetKey(KeyCode.S)  )
        {
            animator.SetBool("Walk", true);

           if(!source.isPlaying)
            {
                source.Play();
            }
           
        }
       
        else
        {
            animator.SetBool("Walk", false);
        }


        if (Input.GetKey(KeyCode.W)&& Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("Run", true);
            if (!source.isPlaying)
            {
                source.Play();
            }

        }
        else
        {
            animator.SetBool("Run", false);
        }





        if (Input.GetKeyDown(KeyCode.Space) &&  !jumping)
        {
            animator.SetTrigger("Jump");
            jumping = true;
            StartCoroutine(Delay(1.15f));
            
        }


       if (Input.GetKey(KeyCode.LeftControl) )
        {
            animator.SetBool("CrouchIdle",true);
            
            
        }
        else{
            animator.SetBool("CrouchIdle",false);
        }


        if (Input.GetKey(KeyCode.LeftControl) &&  (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) ||Input.GetKey(KeyCode.A) ||Input.GetKey(KeyCode.D) ) )
        {
        
            animator.SetBool("CrouchWalk",true);
            silent = true;
        }
        else{
            animator.SetBool("CrouchWalk",false);
            silent = false;
        }



    }
        IEnumerator Delay(float time)
    {
     yield return new WaitForSeconds(time);
        jumping = false;
     // Code to execute after the delay
    }
}