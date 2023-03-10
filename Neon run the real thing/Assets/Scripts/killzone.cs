using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killzone : MonoBehaviour
{
    public static int checkpoint;
    // Start is called before the first frame update
    void Awake()
    {
        checkpoint = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
        

    }
}
