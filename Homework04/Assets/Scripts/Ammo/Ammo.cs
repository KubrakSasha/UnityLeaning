using UnityEngine;

public abstract class Ammo : MonoBehaviour
{
    protected Rigidbody rb;
   
        
    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void OnEnable()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;        
    }
    public abstract void Fire(Vector3 position);
}