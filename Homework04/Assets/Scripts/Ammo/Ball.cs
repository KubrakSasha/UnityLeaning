using UnityEngine;

public class Ball : Ammo
{
    float velocity = 10f;
    public override void Fire()
    {   
        this.gameObject.GetComponent<Rigidbody>().AddForce(direction * velocity, ForceMode.Impulse);          
    }
}
