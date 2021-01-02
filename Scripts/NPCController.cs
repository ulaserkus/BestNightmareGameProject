//using Boo.Lang;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public  class NPCController : MonoBehaviour
{
    public float patrolTime = 15; 
    public  float aggroRange = 10; 
    public Transform[] waypoints; 

    int index;
    float speed, agentSpeed; 
    Transform player;
    

    public Animator animator; 
    public NavMeshAgent agent; 

    [Header("Use for Debugging Aggro Radius")] 
    public bool showAggro = true;
    public bool hit;
    UpdateAnimator updateAnimator;
 
    void Awake()
    {
       
       
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        if (agent != null) { agentSpeed = agent.speed; }
        player = GameObject.FindGameObjectWithTag("Player").transform;
        index = Random.Range(0, waypoints.Length);


        animator.SetBool("Walk", true);
       
        InvokeRepeating("Tick", 0, 0.5f);
        if (waypoints.Length > 0)
        {
            InvokeRepeating("Patrol", Random.RandomRange(0, patrolTime), patrolTime);
            
           
        }
        

    }
    private void Start()
    {

    }

    void Patrol()
    {
        index = index == waypoints.Length - 1 ? 0 : index + 1;




    }
    void Tick()
    {
        agent.destination = waypoints[index].position;
        agent.speed = agentSpeed / 2; 

        if (player != null && Vector3.Distance(transform.position, player.position) < aggroRange) 
        {
            agent.destination = player.position;  
            agent.speed = agentSpeed; 
            
          
            gameObject.transform.LookAt(player.transform);
            if (player != null && Vector3.Distance(transform.position, player.position) <= 2.3f)
            {
               animator.SetBool("Walk",false);

                

                if (hit)
                {

                   
                    hit = false;
                    
                  

                   

                }


            }
            else if (player != null && Vector3.Distance(transform.position, player.position) > 2f && player != null && Vector3.Distance(transform.position, player.position) < aggroRange)
            {
                animator.SetBool("Walk",true);
                hit = true;
            }

        }

        else
        {
            
            animator.SetBool("Walk",true);
            hit = true;
        }

    }
    private void OnDrawGizmos()
    {
        if (showAggro&& UpdateAnimator.silent==false)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, aggroRange); // sphere þeklinde menzil belirt.
        }
        else if (showAggro && UpdateAnimator.silent==true)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, 2); // sphere þeklinde menzil belirt.
        }
    }


    private void Update()
    {

        

    }
}
