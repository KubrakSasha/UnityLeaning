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

    public  Dictionary<AmmoType, List<Ammo>> ammoContainer; 
    [SerializeField] List<Ammo> bullets;
    [SerializeField] List<Ammo> grenades;
    [SerializeField] List<Ammo> balls;
    private void Awake()
    {
        ammoContainer = new Dictionary<AmmoType, List<Ammo>>();

        bullets = new List<Ammo>(bulletAmount);
        for (int i = 0; i < bulletAmount; i++)
        {
            Ammo bullet = Instantiate(bulletPrefab);
            bullet.transform.SetParent(transform);
            bullet.gameObject.SetActive(false);
            bullets.Add(bullet);
        }

        grenades = new List<Ammo>(grenadesAmount);
        for (int i = 0; i < grenadesAmount; i++)
        {
            Ammo grenade = Instantiate(grenadePrefab);
            grenade.transform.SetParent(transform);
            grenade.gameObject.SetActive(false);
            grenades.Add(grenade);
        }

        balls = new List<Ammo> (ballsAmount);
        for (int i = 0; i < ballsAmount; i++)
        {
            Ammo ball = Instantiate(ballPrefab);
            ball.transform.SetParent(transform);
            ball.gameObject.SetActive(false);
            balls.Add(ball);
        }
        ammoContainer.Add(AmmoType.bullet, bullets);
        ammoContainer.Add(AmmoType.grenade, grenades);
        ammoContainer.Add(AmmoType.ball, balls);    
    }

    public Ammo GetAmmo(AmmoType type) 
    {
        Ammo ammo = null;
        for (int i = 0; i < ammoContainer.Count; i++)
        {
            if (!ammoContainer[type][i].gameObject.activeInHierarchy)
            {
                ammo = ammoContainer[type][i];
                ammo.gameObject.SetActive(true);
                return ammo;
            }            
        }
        //switch (type)
        //{
        //    case AmmoType.bullet:
        //        break;
        //    case AmmoType.grenade:
        //        break;
        //    case AmmoType.ball:
        //        break;
        //    default:
        //        break;
        //}
        return null;
    }
}