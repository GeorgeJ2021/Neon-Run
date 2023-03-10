using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcontroller : MonoBehaviour
{
    Animator animator;
    public Rigidbody RB;
    [SerializeField]bool isGrounded;
    int flag= 1;
    
    int isrunHash;
    int issprintHash;
    [SerializeField] int isjumpHash;
    [SerializeField] int isfallHash;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
        RB=GetComponent<Rigidbody>();
        isrunHash = Animator.StringToHash("isrun");
        issprintHash = Animator.StringToHash("issprint");
        isjumpHash = Animator.StringToHash("isjump");
        isfallHash = Animator.StringToHash("isfall");
        
    }

    // Update is called once per frame
    void Update()
    {
        bool runforward=Input.GetKey("w");
        bool isrun=animator.GetBool(isrunHash);
        bool sprintforward=Input.GetKey("left shift");
        bool issprint=animator.GetBool(issprintHash);
        bool jump=Input.GetKeyDown("space");
        bool isjump=animator.GetBool(isjumpHash);
        bool isfall=animator.GetBool(isfallHash);

        void OnCollisionEnter(Collision collision)
        {
            //Debug.Log("Entered");
            flag=1;
            
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = true;
                
                
            }
        }

        void OnCollisionExit(Collision collision)
        {
            //Debug.Log("Exited");
            flag=0;
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = false;
                
            }
        }

        if(!isrun && (runforward))
        {
            animator.SetBool(isrunHash,true);
        }
         if((isrun && (!runforward)))
        {
            animator.SetBool(isrunHash,false);
        }
        if(!issprint && (runforward && sprintforward))
        {
            animator.SetBool(issprintHash,true);
        }
         if(issprint && (!runforward || !sprintforward)  )
        {
            animator.SetBool(issprintHash,false);
        }
        if(!isjump && (jump && isGrounded))
        {
            animator.SetBool(isjumpHash,true);
        }
        if(isjump && (!jump || isGrounded))
        {
            animator.SetBool(isjumpHash,false);
            
        }   
        if(flag==1)
        {
            animator.SetBool(isfallHash, false);
                     
        }
        else if(flag==0)
        {
            animator.SetBool(isfallHash, true);
        }
        
      
        
    }

    

}
