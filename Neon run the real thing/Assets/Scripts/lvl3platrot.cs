using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl3platrot : MonoBehaviour
{
    public Animator animator;
    int isenteredHash;
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
            Debug.Log("boop");
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("ping");
                animator.SetBool(isenteredHash,true);
            }
    }
}
