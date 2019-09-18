using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoopCheck : MonoBehaviour
{
    public bool goopOnGround;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            goopOnGround = true;
        }
    }
}
