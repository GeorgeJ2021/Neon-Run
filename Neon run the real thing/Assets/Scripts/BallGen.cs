using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGen : MonoBehaviour
{
    public GameObject ball1,ball2;
    public float speed = 4;
    public lvl3platrot lvl3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lvl3.PlayerLanded==true)
        {
            //Debug.Log("Beep");
            Instantiate(ball1, transform.position, transform.rotation);
            //b.velocity = transform.forward * speed;
        }
    }

}
