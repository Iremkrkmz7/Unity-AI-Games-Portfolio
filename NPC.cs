using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;
    public Transform player;
    public float detectionRange = 10f;
    public float attackRange = 0.5f;
    public GameObject gameOverText;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    void Update()
    {
        float distance = Vector3.Distance(transform.position , player.position);
        if(distance<= detectionRange)
        {
         if(distance<= attackRange)
         {
            agent.isStopped = true;
            gameOverText.SetActive(true);
            Time.timeScale = 0;
         }   
         else{
            agent.isStopped = false;
            agent.SetDestination(player.position);
         }
        }
        else{
            agent.isStopped=true; 
        }
    }
}

