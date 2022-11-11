using UnityEngine;

public class Stone : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Controller2 controller;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            controller.Die();            
        }
    }
}