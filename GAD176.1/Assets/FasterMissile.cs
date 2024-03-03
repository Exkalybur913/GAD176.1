using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class FasterMissile : BasicMissile
{
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public new void FixedUpdate()
    {
        FindPlayer();
    }

    protected override void FindPlayer()
    {
        Vector2 direction = (Vector2)target.position - rb.position;

        direction.Normalize();

        float turnBy = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = (-turnBy / 3) * turnSpeed;

        rb.velocity = transform.up * (flightSpeed * 3);
    }

}
