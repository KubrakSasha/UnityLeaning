using UnityEngine;
using Cinemachine;
using Unity.VisualScripting;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    [SerializeField] Transform respawnPoint;
    [SerializeField] GameObject playerPrefab;
    [SerializeField] CinemachineVirtualCameraBase cam;
    [SerializeField] GameObject[] enemyPrefabs;
    [SerializeField] Vector3[] enemypositions;

    private void Awake()
    {

        instance = this;        
    }
    private void Start()
    {
        for (int i = 0, j = 0; i < enemyPrefabs.Length; i++, j++)
        {
            enemypositions[j] = enemyPrefabs[i].transform.position; 
        }
    }
    public void Respawn() 
    {
        GameObject player =  Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        cam.Follow = player.transform;
        //Instantiate(enemyPrefabs, enemypositions, Quaternion.identity);
        for (int i = 0; i < enemyPrefabs.Length; i++)
        {
            Instantiate(enemyPrefabs[i], enemypositions[i], Quaternion.identity);
            enemyPrefabs[i].gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
        

    }
}