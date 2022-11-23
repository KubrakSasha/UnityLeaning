using UnityEngine;

public class Bullet : Ammo
{
    [SerializeField] GameObject bulletCollisionPrefab;    
    [SerializeField] GameObject bulletMarkPrefab;
    //AmmoType type = AmmoType.bullet;

    float velocity = 100f;
    
    public override void Fire(Vector3 robotShootDirection)
    {
        AudioManager.Instance.PlayShotClip();        
        rb.AddForce(robotShootDirection * velocity, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        AudioManager.Instance.PlayAudioClip(type);
        this.gameObject.SetActive(false);
        BulletManager.Instance.ReturnToContainer(this);
        var effect = Instantiate(bulletCollisionPrefab, collision.contacts[0].point, Quaternion.identity) as GameObject;
        var bulletMark = Instantiate(bulletMarkPrefab, collision.contacts[0].point, Quaternion.LookRotation(collision.contacts[0].normal));
        Destroy(effect, 0.5f);// c GameObject работает, а с ParticleSystem не работает
        Destroy(bulletMark, 3f);
    }
}