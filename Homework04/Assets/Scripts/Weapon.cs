using UnityEngine;
public class Weapon : MonoBehaviour
{
//    private static Weapon instanse;
//    public static Weapon Instance { get { return instanse; } }
    
    [SerializeField] private GameObject weapon;
    public AmmoType type;  
    public Ammo ammo;

    void Update()
    {
        Shoot();
    }
    public void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {           
            Ammo shell = BulletManager.Instance.GetAmmo(type);
            shell.transform.position = weapon.transform.position;
            shell.transform.rotation = weapon.transform.rotation;
            shell.Fire(transform.right);
        }
    }
}