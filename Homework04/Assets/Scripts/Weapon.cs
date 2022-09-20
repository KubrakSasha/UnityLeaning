using UnityEngine;
public class Weapon : MonoBehaviour
{    
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject grenadePrefab;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject weapon;
    [SerializeField] private float bulletVelocity = 50f;
    [SerializeField] private float ballVelocity = 20f;
    [SerializeField] private float throwForce = 15f;
    public ForceMode forceMode;
    private GameObject prefab;
    private float velocity;
    //private Vector3 force;
    
    void Start()
    {
        prefab = bulletPrefab;
        forceMode = ForceMode.Impulse;        
        velocity = bulletVelocity;
    }    
    void Update()
    {
        if (prefab == grenadePrefab)        
        GrenadeThrow();        
        if(prefab == ballPrefab || prefab == bulletPrefab)
        Shoot();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BallTag") 
        {
            prefab = ballPrefab;
            forceMode = ForceMode.VelocityChange;//Разобраться
            velocity = ballVelocity;            
            Debug.Log("Shells changed to BALLS");            
        }
        if (other.gameObject.tag == "BulletTag")
        {
            prefab = bulletPrefab;
            forceMode = ForceMode.Impulse;//Разобраться
            Debug.Log("Shells changed to BULLETS");
            velocity = bulletVelocity;            
        }
        if (other.gameObject.tag == "GrenadeTag")
        {
            prefab = grenadePrefab;
            forceMode = ForceMode.VelocityChange;//Разобраться
            Debug.Log("Shells changed to GRENADES");
            velocity = throwForce;            
        }
    }    
    public void Shoot() {
       
            if (Input.GetMouseButtonDown(0))
            {
                GameObject shell = Instantiate(prefab, weapon.transform.position, weapon.transform.rotation);
                Rigidbody rbShell = shell.GetComponent<Rigidbody>();            
            rbShell.AddForce(weapon.transform.forward  * velocity, forceMode);            
        }
    }
    public void GrenadeThrow()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject grenade = Instantiate(prefab, weapon.transform.position, weapon.transform.rotation);
            Rigidbody rbGrenade = grenade.GetComponent<Rigidbody>();            
            rbGrenade.AddForce((weapon.transform.forward + weapon.transform.up) * velocity, forceMode);
        }
    }
}