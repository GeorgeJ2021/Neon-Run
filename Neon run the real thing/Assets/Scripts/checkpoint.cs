using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkpoint : MonoBehaviour
{
    int currentcheck;
    
    // Start is called before the first frame update
    /*void Awake()
    {
        KillZone= ded.GetComponent<killzone>();
    } */

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       currentcheck= killzone.checkpoint;
       SceneManager.LoadSceneAsync(currentcheck);
    }
}
