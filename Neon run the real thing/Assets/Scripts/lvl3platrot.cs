using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl3platrot : MonoBehaviour
{
    public Animator animator;
    int isenteredHash;
    public bool PlayerLanded=false;
    //public Collider collider;
        void Start()
    {
        isenteredHash = Animator.StringToHash("isentered");
    }
    // Update is called once per frame
    void Update()
    {
        //bool isjump=animator.GetBool(isjumpHash);
    }
    void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.CompareTag("Player"))
            {
                animator.SetBool(isenteredHash,true);
                PlayerLanded=true;
            }
    }
}
