using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float directionX, moveSpeed = 10f;

    private Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        directionX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        if (Input.GetButtonDown("Jump")) rbody.AddForce(Vector2.up * 500f);
    }

    private void FixedUpdate()
    {
        rbody.velocity = new Vector2(directionX, rbody.velocity.y);
    }
}
