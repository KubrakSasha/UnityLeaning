using UnityEngine;

public class Bullet : Ammo
{
    [SerializeField] GameObject bulletCollisionPrefab;
    [SerializeField] GameObject bulletTrailPrefab;
    [SerializeField] GameObject bulletMarkPrefab;

    float velocity = 30f;

    public override void Fire(Vector3 robotShootDirection)
    {
        //Instantiate(bulletTrailPrefab, transform.position, Quaternion.identity, this.transform);
        this.gameObject.GetComponent<Rigidbody>().AddForce(robotShootDirection * velocity, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        var effect = Instantiate(bulletCollisionPrefab, collision.contacts[0].point, Quaternion.identity) as GameObject;
        var bulletMark = Instantiate(bulletMarkPrefab, collision.contacts[0].point, Quaternion.LookRotation(collision.contacts[0].normal));
        Destroy(this.gameObject);
        Destroy(effect, 0.5f);// c GameObject работает, а с ParticleSystem не работает
        Destroy(bulletMark, 20f);
    }
}