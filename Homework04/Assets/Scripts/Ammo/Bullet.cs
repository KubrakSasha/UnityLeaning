using UnityEngine;

public class Bullet : Ammo
{
    [SerializeField] GameObject bulletCollisionPrefab;
    [SerializeField] GameObject bulletTrailPrefab;
    float velocity = 30f;

    public override void Fire(Vector3 robotShootDirection)
    {
        Instantiate(bulletTrailPrefab, transform.position, Quaternion.identity, this.transform);
        this.gameObject.GetComponent<Rigidbody>().AddForce(robotShootDirection * velocity, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        var effect = Instantiate(bulletCollisionPrefab, collision.contacts[0].point, Quaternion.identity) as GameObject;
        Destroy(this.gameObject);
        Destroy(effect, 0.5f);// c GameObject работает, а с ParticleSystem не работает
    }
}