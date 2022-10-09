using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] GameObject[] enemiesPrefab;   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Respawn")) 
        {
            Destroy(gameObject);
            
            //for (int i = 0; i < enemiesPrefab.Length; i++)
            //{
            //    if (enemiesPrefab[i] is not null)
            //    {
            //        Destroy(enemiesPrefab[i]);
            //    }
            //}
            LevelManager.instance.Respawn();
        }
    }
}