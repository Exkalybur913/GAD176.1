using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerMovementController : MonoBehaviour
{
    public Vector2 playerDirection;
    public Vector3 mouseDirection;
    protected float playerFlightSpeed = 3.0f;
    protected float playerTurnRate = 100f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        mouseDirection = Input.mousePosition;
        mouseDirection = Camera.main.ScreenToWorldPoint(mouseDirection);

        playerDirection = new Vector2(mouseDirection.x - transform.position.x, mouseDirection.y - transform.position.y);

        playerDirection.Normalize();
        
        transform.up = playerDirection;

        rb.velocity = playerDirection * playerFlightSpeed;
    }

    private void PlayerSpeedController()
    {
       if (Input.GetMouseButton(0))
        {
            playerFlightSpeed += 2;
            playerTurnRate /= 2;
            print ("Clicked");
        }

        if (Input.GetMouseButton(1))
        {

        }

        if (Input.GetMouseButton(2))
        {

        }
    }
}
