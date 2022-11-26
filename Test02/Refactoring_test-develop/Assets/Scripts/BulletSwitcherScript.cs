using UnityEngine;

public class BulletSwitcherScript : MonoBehaviour
{
    public Bullet bullet;    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Character")
        {
            other.gameObject.GetComponent<Character>().bullet = bullet.gameObject;
            other.gameObject.GetComponent<Character>().newGun = bullet.gun;
        }
    }
}
