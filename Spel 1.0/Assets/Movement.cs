using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Range(0, 20f)]
    public float movespeed;
    public float jumpHeight;
    public int jumps;
    public ParticleSystem jumpParticle;


    public GroundCheck groundCheck;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        jumps = 2;
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movespeed, rbody.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

    }

    void Jump()
    {
        if (jumps > 0)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
            groundCheck.grounded = false;
            jumps = jumps - 1;
            Instantiate(jumpParticle, transform.position, jumpParticle.transform.rotation);

        }
        if(jumps == 0)
        {
            return;
        }
    }
}
