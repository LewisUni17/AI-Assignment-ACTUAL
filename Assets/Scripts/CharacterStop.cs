using System;
using UnityEngine;
using UnityEngine.AI;
using Yarn;
using Yarn.Unity;

public class CharacterStop : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;

    void Start()
    {
        // Get reference to NavMeshAgent component
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Called when dialogue starts
    [YarnCommand("startTalking")]
    public void StartDialogue()
    {
        // Pause Nav Mesh Agent
        if (navMeshAgent != null)
        {
            navMeshAgent.isStopped = true;
            navMeshAgent.velocity = Vector3.zero;
        }
    }

    // Called when dialogue ends
    public void EndDialogue()
    {
        // Resume Nav Mesh Agent
        if (navMeshAgent != null)
        {
            navMeshAgent.isStopped = false;
        }
    }
}
