using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : Singleton<BulletManager>
{
    [SerializeField] int bulletAmount = 10;
    [SerializeField] int grenadesAmount = 5;
    [SerializeField] int ballsAmount = 17;

    [SerializeField] Ammo bulletPrefab;
    [SerializeField] Ammo grenadePrefab;
    [SerializeField] Ammo ballPrefab;

    public Dictionary<AmmoType, Queue<Ammo>> ammoContainer;
    [SerializeField] Queue<Ammo> bullets;
    [SerializeField] Queue<Ammo> grenades;
    [SerializeField] Queue<Ammo> balls;
    private void Awake()
    {
        ammoContainer = new Dictionary<AmmoType, Queue<Ammo>>();

        bullets = new Queue<Ammo>(bulletAmount);
        for (int i = 0; i < bulletAmount; i++)
        {
            Ammo bullet = Instantiate(bulletPrefab);
            bullet.transform.SetParent(transform);
            bullet.gameObject.SetActive(false);
            bullets.Enqueue(bullet);
        }

        grenades = new Queue<Ammo>(grenadesAmount);
        for (int i = 0; i < grenadesAmount; i++)
        {
            Ammo grenade = Instantiate(grenadePrefab);
            grenade.transform.SetParent(transform);
            grenade.gameObject.SetActive(false);
            grenades.Enqueue(grenade);
        }

        balls = new Queue<Ammo>(ballsAmount);
        for (int i = 0; i < ballsAmount; i++)
        {
            Ammo ball = Instantiate(ballPrefab);
            ball.transform.SetParent(transform);
            ball.gameObject.SetActive(false);
            balls.Enqueue(ball);
        }
        ammoContainer.Add(AmmoType.bullet, bullets);
        ammoContainer.Add(AmmoType.grenade, grenades);
        ammoContainer.Add(AmmoType.ball, balls);
    }

    public Ammo GetAmmo(AmmoType type)
    {        
        Ammo ammo = null;
        ammo = ammoContainer[type].Dequeue();
        ammo.gameObject.SetActive(true);       
        return ammo;
        
    }
    public void ReturnToContainer(Ammo ammo)  
    {
        ammoContainer[ammo.type].Enqueue(ammo);        
    }
    
}