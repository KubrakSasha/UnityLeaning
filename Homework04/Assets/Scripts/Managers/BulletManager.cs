using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    private static BulletManager instance;
    public static BulletManager Instance {get{return instance;}}
    [SerializeField] int bulletAmount =10;
    [SerializeField] Ammo bulletPrefab;
    [SerializeField] List<Ammo> bullets;
    private void Awake()
    {
        instance = this;
        bullets = new List<Ammo>(bulletAmount);
        for (int i = 0; i < bulletAmount; i++)
        {
            Ammo bullet = Instantiate(bulletPrefab);
            bullet.transform.SetParent(transform);
            bullet.gameObject.SetActive(false);
            bullets.Add(bullet);
        }
        
    }

    public Ammo GetAmmo() 
    {
        foreach (var bullet1 in bullets)
        {
            if (!bullet1.gameObject.activeInHierarchy)
            bullet1.gameObject.SetActive(true);
            return bullet1;

        }
        Ammo bullet = Instantiate(bulletPrefab);
        bullet.transform.SetParent(transform);        
        bullets.Add(bullet);
        return bullet;

    }

}
