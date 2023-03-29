using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGen : MonoBehaviour
{
    public GameObject ball1;
    public float speed = 4;
    public lvl3platrot lvl3;
    public float st,rt;
    public GameObject lone;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Ballgenerator", st, rt);
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(Ballgenerator());

    }
    void Ballgenerator()
    {
        if(lvl3.PlayerLanded==true)
        {

            lone=Instantiate(ball1, transform.position, transform.rotation);
            lone.GetComponent<Rigidbody>().AddForce(-5000.0f,0,0,ForceMode.Impulse);


        }
    }
}

