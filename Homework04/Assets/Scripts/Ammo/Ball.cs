using UnityEngine;

public class Ball : Ammo
{
    [SerializeField] GameObject bounceEffectPrefab;
    int collisionsCount = 0;    
    float velocity = 10f;

    public override void Fire(Vector3 robotShootDirection)
    {
        rb.AddForce(robotShootDirection * velocity, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        collisionsCount++;
        AudioManager.Instance.PlayAudioClip(type);       
        if (collisionsCount > 2)
        {            
            gameObject.SetActive(false);
            collisionsCount = 0;
            BulletManager.Instance.ReturnToContainer(this);
        }
        
        var effect = Instantiate(bounceEffectPrefab, collision.contacts[0].point, Quaternion.identity) as GameObject;
        Destroy(effect, 0.5f);
    }
}