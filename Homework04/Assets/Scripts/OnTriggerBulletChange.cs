using UnityEngine;

public class OnTriggerBulletChange : MonoBehaviour
{    
    [SerializeField] AmmoType ammoptype;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            other.GetComponent<Weapon>().type = ammoptype;
    }
    
}