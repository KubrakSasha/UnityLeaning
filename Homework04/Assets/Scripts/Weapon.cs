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
            Ammo shell = Instantiate(ammo, weapon.transform.position, weapon.transform.rotation);
            shell.Fire(transform.right);
        }
    }
}