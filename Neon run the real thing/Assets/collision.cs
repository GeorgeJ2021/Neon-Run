using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour

{
    bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
{
    Debug.Log("Entered");
    if (collision.gameObject.CompareTag("Ground"))
    {
        isGrounded = true;
    }
}

void OnCollisionExit(Collision collision)
{
    Debug.Log("Exited");
    if (collision.gameObject.CompareTag("Ground"))
    {
        isGrounded = false;
    }
}
}
