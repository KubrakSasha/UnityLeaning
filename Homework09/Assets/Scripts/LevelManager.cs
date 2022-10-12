using UnityEngine;
using Cinemachine;
using Unity.VisualScripting;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    [SerializeField] Transform respawnPoint;
    [SerializeField] GameObject playerPrefab;
    [SerializeField] CinemachineVirtualCameraBase cam;
    [SerializeField] GameObject[] enemies;
    [SerializeField] GameObject enemyPrefab;
    Vector3[] enemypositions;
    [SerializeField] Canvas canvas;

    private void Awake()
    {

        instance = this;
       
    }
    private void Start()
    {
        enemypositions = new Vector3[enemies.Length];

        for (int i = 0, j = 0; i < enemies.Length; i++, j++)
        {
            enemypositions[j] = enemies[i].transform.position;
        }
        EventManager.Restart += Respawn;

    }
    public void Respawn() 
    {

        GameObject player =  Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        cam.Follow = player.transform;
        for (int i = 0; i < enemypositions.Length; i++)
        {
            Instantiate(enemyPrefab, enemypositions[i], Quaternion.identity);            
        }
        canvas.gameObject.SetActive(false);

    }
}