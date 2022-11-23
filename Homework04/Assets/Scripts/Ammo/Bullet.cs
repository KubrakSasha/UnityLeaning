using UnityEngine;

public class Bullet : Ammo
{
    [SerializeField] GameObject bulletCollisionPrefab;
    [SerializeField] GameObject bulletTrailPrefab;
    [SerializeField] GameObject bulletMarkPrefab;
    AmmoType type = AmmoType.bullet;

    //Rigidbody rb;

    float velocity = 100f;
    
    public override void Fire(Vector3 robotShootDirection)
    {
        AudioManager.Instance.PlayShotClip();
        //Instantiate(bulletTrailPrefab, transform.position, Quaternion.identity, this.transform);
        //this.gameObject.GetComponent<Rigidbody>().AddForce(robotShootDirection * velocity, ForceMode.Impulse);
        rb.AddForce(robotShootDirection * velocity, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        AudioManager.Instance.PlayAudioClip(type);
        this.gameObject.SetActive(false);
        var effect = Instantiate(bulletCollisionPrefab, collision.contacts[0].point, Quaternion.identity) as GameObject;
        var bulletMark = Instantiate(bulletMarkPrefab, collision.contacts[0].point, Quaternion.LookRotation(collision.contacts[0].normal));
        Destroy(effect, 0.5f);// c GameObject работает, а с ParticleSystem не работает
        Destroy(bulletMark, 3f);
    }
}