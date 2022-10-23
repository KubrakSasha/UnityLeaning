using UnityEngine;
using UnityEngine.AI;

public class LoweSpeedTrigger : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    private void OnTriggerEnter(Collider other)
    {
        agent.speed = 1;
        Debug.Log(agent.speed);
    }
    private void OnTriggerExit(Collider other)
    {
        agent.speed = 3.5f;//уг
    }
}