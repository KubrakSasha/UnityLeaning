using UnityEngine;

public class Grenades : Ammo
{
    [SerializeField] GameObject explosioEffect;// Destroy c GameObject работает, а с ParticleSystem не работает

    Vector3 direction = Vector3.up;
    float throwForce = 10f;
    float radius = 5f;
    float explosionRadius = 5f;
    float explosionForce = 1000f;
    AmmoType type = AmmoType.grenade;

    public override void Fire(Vector3 robotShootDirection)
    {
        rb.AddForce((direction + robotShootDirection) * throwForce, ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        AudioManager.Instance.PlayAudioClip(type);
        Explode();
    }

    private void Explode()
    {
        var explosion = Instantiate(explosioEffect, transform.position, Quaternion.identity) as GameObject;
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        
        foreach (Collider collider in colliders)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            }
        }
        gameObject.SetActive(false);        
        Destroy(explosion, 2f);
    }
}
