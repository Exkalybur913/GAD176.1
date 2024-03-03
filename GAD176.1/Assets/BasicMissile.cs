using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class BasicMissile : MonoBehaviour
{
    public Transform target;
    protected Rigidbody2D rb;
    protected float flightSpeed = 1.5f;
    protected float turnSpeed = 300f;
    protected GameObject Expurosion;
    public PlayerStatController playerStatController;
    public BossStatController bossStatController;
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        FindPlayer();
    }

    // Update is called once per frame
    protected virtual void FindPlayer()
    {
        Vector2 direction = (Vector2)target.position - rb.position;

        direction.Normalize();

        float turnBy = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = -turnBy * turnSpeed;

        rb.velocity =transform.up * flightSpeed;
    }


    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            playerStatController.PlayerTakeDamage(10);
            //print("Kaboom");
            Destroy(gameObject);
            print (playerStatController.playerHealth);
        }

        else if (other.gameObject.CompareTag("Obstacle"))
        {
            print("Missed Player");
            Destroy(gameObject);
        }

        else if (other.gameObject.CompareTag("Bossman"))
        {
            bossStatController.BossTakeDamage(10);
            print("Hit Boss");
            
            Destroy(gameObject);
        }

    }
}
