using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] float time;
    [SerializeField] float range = 2.5f;
    [SerializeField] float force = 150.0f;
    [SerializeField] float explosionRange = 5.0f;    
    bool isActive;    

    void FixedUpdate() {
        if (isActive)
        {
            time -= Time.deltaTime;
        }
        if (time <= 0)
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, range, 512);
            foreach (var collider in colliders)
            {
                collider.GetComponent<Rigidbody>().AddExplosionForce(force, transform.position, explosionRange);
            }
            Destroy(this);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isActive = true;
    }
}
