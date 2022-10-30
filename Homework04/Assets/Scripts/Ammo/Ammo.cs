using UnityEngine;

public abstract class Ammo : MonoBehaviour
{
    protected Vector3 direction = Vector3.forward;   
    public float speed;    
    public abstract void Fire();  
    
    
}
