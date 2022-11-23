using UnityEngine;

public class Ball : Ammo
{
    [SerializeField] GameObject bounceEffectPrefab;
    AmmoType type = AmmoType.ball;
    float velocity = 10f;

    public override void Fire(Vector3 robotShootDirection)
    {
        rb.AddForce(robotShootDirection * velocity, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        AudioManager.Instance.PlayAudioClip(type);

        gameObject.SetActive(false);
        //var effect = Instantiate(bounceEffectPrefab, collision.contacts[0].point, Quaternion.identity) as GameObject;
        //Destroy(effect, 0.5f);
    }
}