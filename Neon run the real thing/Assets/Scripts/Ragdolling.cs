using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdolling : MonoBehaviour
{
    public Collider mainCollider;
    public GameObject Dummy;
    public Animator Dummyanimator;
    public bool RagDollMode = false;

    Collider[] RagDollColliders;
    Rigidbody[] RagDollRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        GetRagDoll();
        RagDollOff();
    }

    // Update is called once per frame
    void Update()
    {
        if(RagDollMode==true)
        {
            RagDollOn();
        }
    }

    /* private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ouch" || RagDollMode==true)
        {
            RagDollOn();
        }
        
    }*/

    void GetRagDoll()
    {
        RagDollColliders = Dummy.GetComponentsInChildren<Collider>();
        RagDollRigidbody = Dummy.GetComponentsInChildren<Rigidbody>();

    }

    void RagDollOn()
    {
        foreach(Collider col in RagDollColliders)
        {
            col.enabled = true;
        }
        foreach(Rigidbody rig in RagDollRigidbody)
        {
            rig.isKinematic = false;
            rig.useGravity = true;
        }

        Dummyanimator.enabled = false;
        mainCollider.enabled = false;
        
    }

    void RagDollOff()
    {
        foreach(Collider col in RagDollColliders)
        {
            col.enabled = false;
        }
        foreach(Rigidbody rig in RagDollRigidbody)
        {
            rig.isKinematic = true;
            rig.useGravity = false;
        }

        Dummyanimator.enabled = true;
        mainCollider.enabled = true;
        
    }
}
