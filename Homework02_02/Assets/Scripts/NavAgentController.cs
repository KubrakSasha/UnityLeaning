using UnityEngine;
using UnityEngine.AI;

public class NavAgentController : MonoBehaviour
{
    Camera cam;
    NavMeshAgent agent;
    
    void Start()
    {
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit)) 
            {
                agent.SetDestination(hit.point);
                //NavMesh.SamplePosition(,);
                
            }
        }        
    }
}
