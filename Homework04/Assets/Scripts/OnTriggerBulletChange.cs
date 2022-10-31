using UnityEngine;

public class OnTriggerBulletChange : MonoBehaviour
{
    [SerializeField] Ammo ammoprefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Weapon weapon))
        {
            weapon.ammo = this.ammoprefab;
        }
    }
}