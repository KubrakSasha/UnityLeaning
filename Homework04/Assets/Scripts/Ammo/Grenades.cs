using UnityEngine;

public class Grenades : Ammo
{
    [SerializeField] GameObject explosioEffect;
    new Vector3 direction = Vector3.forward + Vector3.up;
    float throwVelocity = 10f;
    public override void Fire()
    {
        this.gameObject.GetComponent<Rigidbody>().AddForce(this.direction * throwVelocity, ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Explode();
    }
    

    private void Explode()
    {
        //GameObject explosion = Instantiate(explosioEffect, transform.position, Quaternion.identity);
        Collider[] colliders = Physics.OverlapSphere(transform.position, 5f);
        foreach (Collider collider in colliders)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(900f, transform.position, 5f);
            }
        }
        Destroy(gameObject);
        //Destroy(explosioEffect,1f);
    }   
}
