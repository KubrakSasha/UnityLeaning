using UnityEngine;

public class Ball : Ammo
{
    [SerializeField] GameObject bounceEffectPrefab;
    float velocity = 10f;

    public override void Fire(Vector3 robotShootDirection)
    {
        this.gameObject.GetComponent<Rigidbody>().AddForce(robotShootDirection * velocity, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        var effect = Instantiate(bounceEffectPrefab, collision.contacts[0].point, Quaternion.identity) as GameObject;
        Destroy(effect, 0.5f);
    }
}