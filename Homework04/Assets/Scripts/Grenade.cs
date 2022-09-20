using UnityEngine;

public class Grenade : MonoBehaviour
{
    //public float delay = 3f;
    public float radius = 7f;
    float forceGrenade = 900f;
    //float countdown;
    //bool hasExploded = false;
    public GameObject explosionEffect;
    void Start()
    {
        //countdown = delay;
    }
    void Update()
    {
        //countdown -= Time.deltaTime;
        //if (countdown <= 0 && !hasExploded)
        //{
        //    Explode();
        //    hasExploded = true;
        //}
    }
    public void Explode() 
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);// решить       
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearOdjects in colliders)
        {
            Rigidbody rigidbody = nearOdjects.GetComponent<Rigidbody>();
            if (rigidbody != null)
            {
                rigidbody.AddExplosionForce(forceGrenade, transform.position, radius);
            }
        }
        Debug.Log("BOOM");
        Destroy(gameObject);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Explode();
        Debug.Log(collision.gameObject);
    }
}