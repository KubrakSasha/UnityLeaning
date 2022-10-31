using UnityEngine;
using UnityEngine.AI;

public class LoweSpeedTrigger : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    
    private void OnTriggerEnter(Collider other)
    {
        SetSpeedCoeff(0.5f);
    }
    private void OnTriggerExit(Collider other)
    {
        SetSpeedCoeff(2f);
    }

    float SetSpeedCoeff(float coef)
    {
        agent.speed *= coef;
        return agent.speed;
    }
} 