using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotAi : MonoBehaviour
{
    public NavMeshAgent bot;
    public Transform player;
    public lvl3platrot ll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ll.PlayerLanded==true)
        {
            bot.SetDestination(player.position);
        }
        //bot.SetDestination(player.position);
    }
}
