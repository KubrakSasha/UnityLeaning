using UnityEngine;
public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject weapon;
    public Ammo ammo;

    void Update()
    {
        Shoot();
    }
    public void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            //Ammo shell = Instantiate(ammo, weapon.transform.position, weapon.transform.rotation);
            Ammo shell = BulletManager.Instance.GetAmmo();
            shell.transform.position = weapon.transform.position;
            shell.transform.rotation = weapon.transform.rotation;

            shell.Fire(transform.right);
        }
    }
}