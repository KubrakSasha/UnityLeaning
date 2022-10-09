using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] Transform player;
    [SerializeField] float speed;
    [SerializeField] float agroDistance;
    Vector2 path;
    Vector2 path2;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        path2 = rb.transform.position;
        path = path2 + new Vector2(5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(path2, path, Mathf.PingPong(Time.time,1));
        //float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        //if (distanceToPlayer < agroDistance)
        //{
        //    StartHunting();
        //}
        //else
        //{
        //    StopHunting();
        //}
    }
    void StartHunting() 
    {
        if (player.position.x < transform.position.x)
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        else if (player.position.x > transform.position.x)
        {
            rb.velocity = new Vector2(speed, 0);
        }
    }
    void StopHunting()
    {
        rb.velocity = Vector2.zero;
    }
}
