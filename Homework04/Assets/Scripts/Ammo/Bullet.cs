using UnityEngine;

public class Bullet : Ammo{
    
    float velocity = 30f;
    public override void Fire() 
    {
        this.gameObject.GetComponent<Rigidbody>().AddForce(direction * velocity, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)  
    {
        Destroy(this.gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
