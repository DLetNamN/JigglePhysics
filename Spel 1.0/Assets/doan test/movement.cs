using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 10;
    public float jump = 10;

    private Rigidbody2D rbody;


    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jump);
        }
    }

}
